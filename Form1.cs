using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace lanware_cliente
{
    public partial class frm_login : Form
    {
        [DllImport("winmm.dll")]
        static extern bool PlaySound(string file, int module, int flags);

        NpgsqlConnection kronos_conn = new NpgsqlConnection();
        RegistryKey ch_conf = Registry.CurrentUser;
        frm_timed tempo = null;

        public frm_login()
        {
            InitializeComponent();
            label8.Text = "Versão: " + Application.ProductVersion;
            label9.Text = Environment.MachineName;
        }

        public void log(string text)
        {
            string agora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            StreamWriter log_file = new StreamWriter("C:\\WINDOWS\\TEMP\\lanware_cliente.log", true, Encoding.ASCII);

            try
            {
                log_file.WriteLine(agora + " - " + text);
                log_file.Close();
            }
            catch (Exception error)
            {
                log_file.WriteLine(agora + " - " + error.Message);
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            edt_nick.Text = null;
            edt_senha.Text = null;
            edt_nick.Focus();

            log("Iniciando programa...");
            // Carregando valores do registro do windows...

            if (File.Exists(Application.StartupPath + "\\default.jpg"))
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\default.jpg");
            }

            log("Carregando valores do registro...");
            ch_conf = ch_conf.OpenSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");

            String vServidor = ch_conf.GetValue("Servidor").ToString();
            String vUsuario = ch_conf.GetValue("Usuario pgsql").ToString();
            String vSenha = ch_conf.GetValue("Senha pgsql").ToString();
            String vBanco = ch_conf.GetValue("Database").ToString();

            kronos_conn.ConnectionString = "Server=" + vServidor + ";User Id=" + vUsuario + ";Password=" + vSenha + ";Database=" + vBanco + ";";

            log("Tentando conectar ao banco de dados...");
            if (conecta())
            {
                log("Conexão com banco realizada com sucesso!");
                log("Derrubando processos...");
                this.kill_process();
                log("Desconectando do banco...");
                this.desconecta();
            }
            else
            {
                log("Não foi possível conxão com banco de dados...");
                lb_error.Text = "Erro ao conextar com banco de dados... tentando em 10 segundos...";
                lb_error.ForeColor = Color.Red;
                lb_error.Visible = true;
                tmp_erro.Enabled = true;
            }
            //this.kill_process();
        }

        public virtual bool valida_login(string login, string senha)
        {
            Boolean resultado = true;

            log("Iniciando validacao para : " + login + " e senha : " + senha);
                NpgsqlCommand vUserValid = new NpgsqlCommand("select usr.nick, usr.senha, esp.tmp_add, esp.tmp_rest from usuarios usr, espera esp where usr.nick = '" + login + "' and usr.senha = '" + senha + "' and usr.nick = esp.nick and esp.tmp_rest <> '00:00:00' and esp.status = 'novo'", kronos_conn);
                NpgsqlDataReader drUser = vUserValid.ExecuteReader();

                if (drUser.Read())
                {
                    log("Encontrado registro: " + drUser[0].ToString() + " : " + drUser[1].ToString() + " add: " + drUser[2].ToString() + " rest: " + drUser[3].ToString());
                    //RegistryKey key_login = Registry.CurrentUser;
                    //key_login = key_login.CreateSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
                    //key_login.SetValue("login", login);
                    DateTime inicio = DateTime.Now;
                    NpgsqlCommand del_esp = new NpgsqlCommand("delete from espera where nick = '" + login + "'", kronos_conn);
                    NpgsqlCommand ins_ativ = new NpgsqlCommand("update atividade set nick = '" + login + "', tmp_add = '" + drUser[2] + "', tmp_rest = '" + drUser[3] + "', tmp_inicio = '" + inicio.ToString("HH:mm:ss") + "', tmp_fim = '00:00:00' where maquina = '" + Environment.MachineName + "'", kronos_conn);

                    int delespres = del_esp.ExecuteNonQuery();
                    if (delespres != 0)
                    {
                        ins_ativ.ExecuteNonQuery();
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                    }
                    drUser.Close();
                    log("Validacao correta...");
                    
                    //return true;
                }
                else
                {
                    log("Validacao errada...");
                    resultado = false;
                    // return false;
                }
                return resultado;
        }

        public virtual bool altera_senha(String senha, String nick)
        {
            log("Alterando senha para : " + nick + " senha : " + senha);
            NpgsqlCommand vAlt_senha = new NpgsqlCommand("update usuarios set senha = '" + senha + "' where nick = '" + nick + "'", kronos_conn);

            Int32 result = vAlt_senha.ExecuteNonQuery();
            if (result != 0)
            {
                log("Alteracao de senha OK!");
                return true;
            }
            else
            {
                log("Erro ao validar senha...");
                return false;
            }
        }

        public void abre_relogio(String nick)
        {
            //if (conecta())
            //{
            log("Abrindo relogio...");
               // RegistryKey key_login = Registry.CurrentUser;
               // key_login = key_login.OpenSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");

                NpgsqlCommand cmdTemp = new NpgsqlCommand("select tmp_add, tmp_rest from atividade where nick ='" + nick + "'", kronos_conn);
                NpgsqlDataReader drTemp = cmdTemp.ExecuteReader();
                if (drTemp.Read())
                {
                    DateTime tmprest = Convert.ToDateTime(drTemp[1]);
                    DateTime tmpadd = Convert.ToDateTime(drTemp[0]);
                    Process.Start("C:\\Arquivos de programas\\MSN Messenger\\msnmsgr.exe");
                    Process.Start("C:\\WINDOWS\\explorer.exe");

                    tempo = new frm_timed();
                    tempo.lb_nick.Text = nick; // ch_conf.GetValue("login").ToString();
                    tempo.lb_add.Text = tmpadd.ToString("HH:mm");
                    tempo.lb_tempo.Text = tmprest.ToString("HH:mm");
                    tempo.TopMost = true;
                    tempo.Show();
                    this.relogio.Enabled = true;
                    this.Hide();
                }
                drTemp.Close();
              //  desconecta();
            //}
        }

        public virtual void logout(string login)
        {
            //if (conecta())
            //{
            log("Realizando logout para : " + login);
                NpgsqlCommand hor_esp = new NpgsqlCommand("select tmp_rest from atividade where nick = '" + login + "' and tmp_rest <> '00:00:00'", kronos_conn);
                NpgsqlDataReader drEsp = hor_esp.ExecuteReader();
                if (drEsp.Read())
                {
                    hor_esp.CommandText = "insert into espera values('" + login + "','" + drEsp[0] + "','" + drEsp[0] + "', '" + DateTime.Now.ToLongTimeString() + "','velho')";
                    hor_esp.ExecuteNonQuery();
                }
                NpgsqlCommand upd_ativ = new NpgsqlCommand("update atividade set nick = '', tmp_inicio = '00:00:00', tmp_fim = '00:00:00', tmp_add = '00:00:00', tmp_rest = '00:00:00' where nick = '" + login + "'", kronos_conn);

                Int32 result = upd_ativ.ExecuteNonQuery();

                if (result != 0)
                {
                    tempo.Close();
                    this.edt_nick.Text = null;
                    this.edt_senha.Text = null;
                    this.nova_senha.Text = null;
                    this.repete_senha.Text = null;
                    this.new_senha.Visible = false;
                    this.relogio.Enabled = false;
                    this.lb_error.Text = "";
                    this.lb_error.Visible = false;
                    this.edt_nick.Enabled = true;
                    this.edt_senha.Enabled = true;
                    this.edt_nick.Focus();
                    this.Show();

                    this.kill_process();
                }
            //}
            //desconecta();
        }

        public virtual void kill_process()
        {
         //   if (conecta())
          //  {
                NpgsqlCommand get_pid = new NpgsqlCommand("select pid from processos", kronos_conn);
                NpgsqlDataReader drPid = get_pid.ExecuteReader();

                while (drPid.Read())
                {
                    Process[] p_nome = Process.GetProcessesByName(drPid[0].ToString());
                    foreach (Process pid in p_nome)
                    {
                        pid.Kill();
                    }
                }
                drPid.Close();
           // }
           // desconecta();
        }

        private void edt_nick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (edt_nick.Text != "") edt_senha.Focus();
            }
        }

        private void edt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (edt_nick.Text != "" && edt_senha.Text != "")
                {
                    lb_error.Text = "Verificando usuario e senha...";
                    lb_error.Visible = true;
                    log("Verificando usuario e senha para " + edt_nick.Text);
                    
                    try
                    {
                        if (conecta())
                        {
                            if (valida_login(edt_nick.Text, edt_senha.Text))
                            {
                                if (edt_nick.Text == edt_senha.Text)
                                {
                                    new_senha.Visible = true;
                                    nova_senha.Focus();
                                    edt_nick.Enabled = false;
                                    edt_senha.Enabled = false;
                                }
                                else
                                {
                                    abre_relogio(edt_nick.Text);
                                }
                            }
                            else
                            {
                                edt_senha.Text = null;
                                edt_nick.Text = null;
                                edt_nick.Focus();
                                lb_error.Text = "Usuário ou senha inválido ...";
                                lb_error.Visible = true;
                            }
                            desconecta();
                        }
                    }
                    catch (Exception error)
                    {
                        lb_error.Text = "Erro validando login e senha : " + error.Message;
                        lb_error.Visible = true;
                    }
                }
            }
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            log("Atividade do relogio...");
            if (conecta())
            {
                tempo.BackColor = Color.Black;
                log("Atividade do relogio: Buscando tempo...");
                // busca tempo no banco diminui 1 minuto mostra no frm_tempo
                NpgsqlCommand cmdAtiv = new NpgsqlCommand("select tmp_add, tmp_rest from atividade where nick = '" + tempo.lb_nick.Text + "'", kronos_conn);
                try
                {
                    NpgsqlDataReader drAtiv = cmdAtiv.ExecuteReader();
                    drAtiv.Read();

                    DateTime dt_add = Convert.ToDateTime(drAtiv[0]);
                    DateTime dt_rest = Convert.ToDateTime(drAtiv[1]);

                    if (dt_rest != Convert.ToDateTime("01/01/0001 00:00:00"))
                    {
                        if (dt_rest == Convert.ToDateTime("01/01/0001 00:05:00"))
                        {
                            tempo.lb_tempo.ForeColor = Color.Red;
                            PlaySound("notifica.wav", 0, 0);
                        }

                        if (dt_rest <= Convert.ToDateTime("01/01/0001 00:05:00"))
                        {
                            tempo.lb_tempo.ForeColor = Color.Red;
                        }
                        else
                        {
                            tempo.lb_tempo.ForeColor = Color.Cyan;
                        }

                        DateTime dt_m_Ativ = dt_rest.AddMinutes(-1);
                        //tempo.lb_tempo.ForeColor = Color.White;
                        tempo.lb_add.Text = dt_add.ToString("HH:mm");
                        tempo.lb_tempo.Text = dt_m_Ativ.ToString("HH:mm");

                        NpgsqlCommand cmdMenos = new NpgsqlCommand("update atividade set tmp_rest = '" + dt_m_Ativ.ToString("HH:mm") + "' where nick = '" + tempo.lb_nick.Text + "'", kronos_conn);
                        int resultado = cmdMenos.ExecuteNonQuery();
                        drAtiv.Close();
                    }
                    else
                    {
                        this.kill_process();
                        log("Atividade do relogio: logout");
                        this.logout(tempo.lb_nick.Text);
                    }
                }
                catch
                {
                    log("Erro ao conectar com banco de dados...");
                    //MessageBox.Show("Erro de conexao");
                    relogio.Enabled = false;
                    tmp_erro.Enabled = true;
                }
                desconecta();
            }
            else
            {
                tempo.BackColor = Color.Red;
            }
        }
        

        private void nova_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nova_senha.Text != "") repete_senha.Focus();
            }
        }

        private void repete_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nova_senha.Text != repete_senha.Text)
                {
                    lb_error.Text = "As senhas são diferente!";
                    lb_error.Visible = true;
                    nova_senha.Text = "";
                    repete_senha.Text = "";
                    nova_senha.Focus();
                }
                else
                {
                    if (nova_senha.Text != "" && repete_senha.Text != "")
                    {
                        if (conecta())
                        {
                            if (altera_senha(nova_senha.Text, edt_nick.Text))
                            {
                                lb_error.Text = "Senha alterada com sucesso!!!";
                                lb_error.Visible = true;
                                new_senha.Visible = false;
                                abre_relogio(edt_nick.Text);
                            }
                            else
                            {
                                lb_error.Text = "A senha não foi alterada!!!";
                                lb_error.Visible = true;
                            }
                            desconecta();
                        }
                    }
                }
            }
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
        }

        private void tmp_erro_Tick(object sender, EventArgs e)
        {
            log("Verificanco a conexão com banco de dados...");
            try
            {
                kronos_conn.Open();
                log("conexão com banco de dados realizada com sucesso!!!");
                lb_error.Text = "";
                lb_error.ForeColor = Color.Cyan;
                lb_error.Visible = false;
                tmp_erro.Enabled = false;
              //  relogio.Enabled = true;
            }
            catch
            {
                log("Não foi possível conxão com banco de dados...");
                lb_error.Text = "Erro ao conextar com banco de dados... tentando em 10 segundos...";
                lb_error.ForeColor = Color.Red;
                lb_error.Visible = true;
            }
        }

        public virtual bool conecta()
        {
            log("Verificando conexao com banco de dados...");
            try
            {
                log("Abrindo conexao...");
                kronos_conn.Open();
                log("Conexao OK...");
                return true;
            }
            catch
            {
                log("Erro ao conectar...");
                return false;
            }
        }

        public virtual void desconecta()
        {
            log("Desconectando do banco...");
            kronos_conn.Close();
        }

        private void edt_nick_Leave(object sender, EventArgs e)
        {
            if (edt_nick.Text != "")
            {
                // locando o registro
            }
            else
            {
                // retirando o lock do registro
            }
        }

        private void frm_login_Activated(object sender, EventArgs e)
        {
            edt_nick.Focus();
        }
    }
}