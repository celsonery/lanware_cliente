using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace lanware_cliente
{
    public partial class frm_timed : UserControl
    {
        frm_login login = (frm_login) frm_login.ActiveForm;
        public frm_timed()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            login.logout();
        }
    }
}
