namespace lanware_cliente
{
    partial class frm_timed
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
            this.lb_sair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_add = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sair.ForeColor = System.Drawing.Color.Red;
            this.lb_sair.Location = new System.Drawing.Point(385, 2);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(29, 15);
            this.lb_sair.TabIndex = 0;
            this.lb_sair.Text = "Sair";
            this.lb_sair.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nick:";
            // 
            // lb_nick
            // 
            this.lb_nick.AutoSize = true;
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.Cyan;
            this.lb_nick.Location = new System.Drawing.Point(36, 2);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(67, 15);
            this.lb_nick.TabIndex = 2;
            this.lb_nick.Text = "MMMMM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(278, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restante:";
            // 
            // lb_tempo
            // 
            this.lb_tempo.AutoSize = true;
            this.lb_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempo.ForeColor = System.Drawing.Color.Cyan;
            this.lb_tempo.Location = new System.Drawing.Point(340, 2);
            this.lb_tempo.Name = "lb_tempo";
            this.lb_tempo.Size = new System.Drawing.Size(43, 15);
            this.lb_tempo.TabIndex = 4;
            this.lb_tempo.Text = "00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "l";
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add.ForeColor = System.Drawing.Color.Cyan;
            this.lb_add.Location = new System.Drawing.Point(232, 2);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(43, 15);
            this.lb_add.TabIndex = 7;
            this.lb_add.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(183, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tempo:";
            // 
            // frm_timed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(415, 22);
            this.ControlBox = false;
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_tempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_nick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(320, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_timed";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_timed_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_sair;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_nick;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_tempo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lb_add;
        public System.Windows.Forms.Label label5;

    }
}