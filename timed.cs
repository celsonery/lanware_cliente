using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace lanware_cliente
{
    public partial class frm_timed : Form
    {
        frm_login login = (frm_login)frm_login.ActiveForm;
        public frm_timed()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (login.conecta())
                {
                    //RegistryKey key_login = Registry.CurrentUser;
                    //key_login = key_login.OpenSubKey("SOFTWARE\\Neo Technologia\\Kronos Lanware");
                    login.kill_process();
                    //login.logout(key_login.GetValue("login").ToString());
                    login.logout(lb_nick.Text);
                    this.Close();
                    login.desconecta();
                }
            }
        }

        private void frm_timed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
        }
    }
}