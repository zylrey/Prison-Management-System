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
    public partial class frmStaffDashboard : Form
    {
        public frmStaffDashboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            loadform(new dashboardpanel());
        }

        private void BtnInmate_Click(object sender, EventArgs e)
        {
            loadform(new inmatepanel());
        }

        private void BtnVisitor_Click(object sender, EventArgs e)
        {
            loadform(new visitorpanel());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logout!");
            this.Hide();
            new Form1().Show();
        }

        private void FrmStaffDashboard_Load(object sender, EventArgs e)
        {
            loadform(new dashboardpanel());
        }
    }
}
