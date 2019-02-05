namespace lanware_cliente
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.new_senha = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repete_senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nova_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_nick = new System.Windows.Forms.TextBox();
            this.edt_senha = new System.Windows.Forms.TextBox();
            this.lb_error = new System.Windows.Forms.Label();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmp_erro = new System.Windows.Forms.Timer(this.components);
            this.new_senha.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_senha
            // 
            this.new_senha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.new_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.new_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_senha.Controls.Add(this.label6);
            this.new_senha.Controls.Add(this.label3);
            this.new_senha.Controls.Add(this.repete_senha);
            this.new_senha.Controls.Add(this.label5);
            this.new_senha.Controls.Add(this.nova_senha);
            this.new_senha.Controls.Add(this.label4);
            this.new_senha.ForeColor = System.Drawing.Color.Black;
            this.new_senha.Location = new System.Drawing.Point(377, 188);
            this.new_senha.Name = "new_senha";
            this.new_senha.Padding = new System.Windows.Forms.Padding(10);
            this.new_senha.Size = new System.Drawing.Size(178, 90);
            this.new_senha.TabIndex = 11;
            this.new_senha.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repetir senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nova senha:";
            // 
            // repete_senha
            // 
            this.repete_senha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.repete_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.repete_senha.Location = new System.Drawing.Point(81, 49);
            this.repete_senha.MaxLength = 20;
            this.repete_senha.Name = "repete_senha";
            this.repete_senha.PasswordChar = '*';
            this.repete_senha.Size = new System.Drawing.Size(90, 20);
            this.repete_senha.TabIndex = 3;
            this.repete_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repete_senha_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(2, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Utilize o máximo de 20 caracteres.";
            // 
            // nova_senha
            // 
            this.nova_senha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nova_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.nova_senha.Location = new System.Drawing.Point(81, 23);
            this.nova_senha.MaxLength = 20;
            this.nova_senha.Name = "nova_senha";
            this.nova_senha.PasswordChar = '*';
            this.nova_senha.Size = new System.Drawing.Size(90, 20);
            this.nova_senha.TabIndex = 1;
            this.nova_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nova_senha_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Digite a nova senha.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(193, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(193, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // edt_nick
            // 
            this.edt_nick.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edt_nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.edt_nick.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.edt_nick.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_nick.ForeColor = System.Drawing.Color.Black;
            this.edt_nick.Location = new System.Drawing.Point(240, 226);
            this.edt_nick.MaxLength = 20;
            this.edt_nick.Name = "edt_nick";
            this.edt_nick.Size = new System.Drawing.Size(120, 21);
            this.edt_nick.TabIndex = 7;
            this.edt_nick.Leave += new System.EventHandler(this.edt_nick_Leave);
            this.edt_nick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edt_nick_KeyDown);
            // 
            // edt_senha
            // 
            this.edt_senha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.edt_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.edt_senha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_senha.ForeColor = System.Drawing.Color.Black;
            this.edt_senha.Location = new System.Drawing.Point(240, 251);
            this.edt_senha.MaxLength = 20;
            this.edt_senha.Name = "edt_senha";
            this.edt_senha.PasswordChar = '*';
            this.edt_senha.Size = new System.Drawing.Size(120, 21);
            this.edt_senha.TabIndex = 8;
            this.edt_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edt_senha_KeyDown);
            // 
            // lb_error
            // 
            this.lb_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_error.AutoSize = true;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.White;
            this.lb_error.Location = new System.Drawing.Point(12, 280);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(50, 13);
            this.lb_error.TabIndex = 12;
            this.lb_error.Text = "lb_error";
            this.lb_error.Visible = false;
            // 
            // relogio
            // 
            this.relogio.Interval = 60000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lanware Cliente - Criado por Neo";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(473, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Versão: 1.3.3.1111";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "KRONOS-GS-02";
            // 
            // tmp_erro
            // 
            this.tmp_erro.Interval = 10000;
            this.tmp_erro.Tick += new System.EventHandler(this.tmp_erro_Tick);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 302);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.new_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_nick);
            this.Controls.Add(this.edt_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kronos Lanware Cliente";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_login_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_login_KeyDown);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.new_senha.ResumeLayout(false);
            this.new_senha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel new_senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repete_senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nova_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_nick;
        private System.Windows.Forms.TextBox edt_senha;
        private System.Windows.Forms.Label lb_error;
        public System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmp_erro;

    }
}

