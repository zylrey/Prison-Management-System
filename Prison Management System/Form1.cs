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
    public partial class Form1 : Form
    {
        private btnLogin lg1;
        public Form1()
        {
            InitializeComponent();
            lg1 = new btnLogin();
            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static string unameForm1;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Close the application when Form1 is closed
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from tbl_user WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            config.singleResult(sql);
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must fill up all the textboxes in order to save.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (config.dt.Rows.Count > 0)
            {
                type = config.dt.Rows[0][6].ToString().Trim();
                if (type == "Warden")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"),"LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Jail Officer")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Police Officer")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if(type == "Nurse")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Nurse " + config.dt.Rows[0].Field<string>("firstname"));
                    this.Hide();
                    new frmNurseDash().Show();
                }
                else
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Staff " + config.dt.Rows[0].Field<string>("firstname"));
                    new frmStaffDashboard().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Unknown User Data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from tbl_user WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            config.singleResult(sql);
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must fill up all the textboxes in order to save.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (config.dt.Rows.Count > 0)
            {
                type = config.dt.Rows[0][6].ToString().Trim();
                if (type == "Warden")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    //unameForm1 = txtUsername.Text;
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //lg1.Show();
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Jail Officer")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    //unameForm1 = txtUsername.Text;
                    //btnLoginJO ljo = new btnLoginJO();
                    //ljo.Show();
                    MessageBox.Show("Successfully logged in, Welcome Jail Officer " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Police Officer")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Nurse")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Nurse " + config.dt.Rows[0].Field<string>("firstname"));
                    this.Hide();
                    new frmNurseDash().Show();
                }
                else
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Staff " + config.dt.Rows[0].Field<string>("firstname"));
                    new frmStaffDashboard().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Unknown User Data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BunifuFlatButton1_Click(this, new EventArgs());
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            new frmVisitScan().Show();
        }

        private void TxtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BunifuFlatButton1_Click(this, new EventArgs());
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from tbl_user WHERE username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            config.singleResult(sql);
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must fill up all the textboxes in order to save.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (config.dt.Rows.Count > 0)
            {
                type = config.dt.Rows[0][6].ToString().Trim();
                if (type == "Warden")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    //unameForm1 = txtUsername.Text;
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //lg1.Show();
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Jail Officer")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    //unameForm1 = txtUsername.Text;
                    //btnLoginJO ljo = new btnLoginJO();
                    //ljo.Show();
                    MessageBox.Show("Successfully logged in, Welcome Jail Officer " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Police Officer")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Admin " + config.dt.Rows[0].Field<string>("firstname"), "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    new frmDashboard().Show();

                }
                else if (type == "Nurse")
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Nurse " + config.dt.Rows[0].Field<string>("firstname"));
                    this.Hide();
                    new frmNurseDash().Show();
                }
                else
                {
                    globals.first_name = config.dt.Rows[0]["firstname"].ToString();
                    globals.type = config.dt.Rows[0]["type"].ToString();
                    MessageBox.Show("Successfully logged in, Welcome Staff " + config.dt.Rows[0].Field<string>("firstname"));
                    new frmStaffDashboard().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Unknown User Data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            // Start the timer when the form loads
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
