using BunifuAnimatorNS;
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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logout!");
            new Form1().Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the application when Form1 is closed
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            loadform(new dashboardpanel());
            /*
            btnDashboard.BackColor = Color.DeepSkyBlue;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/

        }

        private void BtnInmate_Click(object sender, EventArgs e)
        {
            loadform(new inmatepanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DeepSkyBlue;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void BtnVisitor_Click(object sender, EventArgs e)
        {
            loadform(new visitorpanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DeepSkyBlue;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            loadform(new prisonpanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.Gray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            loadform(new cellblockpanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DeepSkyBlue;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            loadform(new crimepanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DeepSkyBlue;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            loadform(new actionpanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            loadform(new reportspanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DeepSkyBlue;
            button7.BackColor = Color.DimGray; */
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            loadform(new userpanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DeepSkyBlue; */
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            loadform(new dashboardpanel());
            lblName.Text = "(" + globals.type + ")  " + globals.first_name ;
            lblType.Text = globals.type;
            lblType.Visible = false;

            if(lblType.Text == "Jail Officer")
            {
                /*
                btnConfirmation.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                //button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                button7.Visible = false;*/
            }
            if (lblType.Text == "Police Officer")
            {
                loadform(new inmatepanel());
                /*
                btnConfirmation.Visible = false;
                btnDashboard.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnVisitor.Visible = false;
                //button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                button7.Visible = false;
                button8.Visible = false; */
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new frmInmateListPanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DeepSkyBlue;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray; */
        }

        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            loadform(new bookingconfirmationpanel());
            /*
            btnDashboard.BackColor = Color.DimGray;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DeepSkyBlue;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void Panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            loadform(new addOfficer());
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            loadform(new dashboardpanel());
            bunifuBtnDash.BackColor = Color.DeepSkyBlue;
            /*
            btnDashboard.BackColor = Color.DeepSkyBlue;
            btnInmate.BackColor = Color.DimGray;
            btnVisitor.BackColor = Color.DimGray;
            button8.BackColor = Color.DimGray;
            btnConfirmation.BackColor = Color.DimGray;
            //button4.BackColor = Color.DimGray;
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.DimGray;
            button6.BackColor = Color.DimGray;
            button5.BackColor = Color.DimGray;
            button7.BackColor = Color.DimGray;*/
        }

        private void BunifuBtnJail_Click(object sender, EventArgs e)
        {
            loadform(new inmatepanel());
            bunifuBtnJail.BackColor = Color.DeepSkyBlue;
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            loadform(new frmInmateListPanel());
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            loadform(new bookingconfirmationpanel());
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            loadform(new visitorpanel());
        }

        private void BunifuBtnCell_Click(object sender, EventArgs e)
        {
            loadform(new cellblockpanel());
        }

        private void BunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            loadform(new crimepanel());
        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            loadform(new actionpanel());
        }

        private void BunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            loadform(new reportspanel());
        }

        private void BunifuBtnUsers_Click(object sender, EventArgs e)
        {
            loadform(new userpanel());
        }

        private void BunifuFlatButton1_Click_3(object sender, EventArgs e)
        {
            loadform(new frmVisitScan());
        }

        private void BunifuBtnPersonel_Click(object sender, EventArgs e)
        {
            loadform(new frmStaffPersonel());
        }
    }
}
