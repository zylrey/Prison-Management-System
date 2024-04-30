using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Management_System
{
    public partial class btnLogin : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;
        private frmDashboard dash;
        public btnLogin()
        {
            InitializeComponent();
            dash = new frmDashboard();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            
            if (form1 != null)
            {
                form1.Hide();
            }

            dash.Show();
        }

        private void BtnLogin_Load(object sender, EventArgs e)
        {
            sql = "SELECT * from tbl_user";
            config.singleResult(sql);

            txtUsername.Text = Form1.unameForm1;
            label2.Text = "Successfully logged in, Welcome " + txtUsername.Text;
        }
    }
}
