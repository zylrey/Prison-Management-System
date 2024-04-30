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
    public partial class frmNurseDash : Form
    {
        public frmNurseDash()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logout!");
            this.Hide();
            new Form1().Show();
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmNurseDash_Load(object sender, EventArgs e)
        {
            loadform(new nurseInmateList());
            lblName.Text = "(" + globals.type + ")  " + globals.first_name;
            lblType.Text = globals.type;
            lblType.Visible = false;
            btnDashboard.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            loadform(new nursePanel());
        }

        private void BtnInmate_Click(object sender, EventArgs e)
        {
            loadform(new nurseInmateList());
        }
    }
}
