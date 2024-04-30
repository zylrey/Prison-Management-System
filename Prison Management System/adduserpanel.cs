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
    public partial class adduserpanel : Form
    {
        public adduserpanel()
        {
            InitializeComponent();
        }

        public getset UserInfo { get; set; }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "" ||
            txtLastname.Text == "" ||
            txtMiddlename.Text == "" || 
            txtUsername.Text == "" ||
            txtPassword.Text == "" ||
            cbType.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_user(firstname,middlename,lastname,username,password,type) VALUES ('" + txtFirstname.Text + "','" + txtMiddlename.Text + "', '" + txtLastname.Text +
                "','" + txtUsername.Text + "','" + txtPassword.Text + "', '" + cbType.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                clear();
                this.Hide();
            }
        }

        private void clear()
        {
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            txtLastname.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void Adduserpanel_Load(object sender, EventArgs e)
        {
            if(UserInfo != null)
            {
                txtFirstname.Text = UserInfo.firstname;
                txtMiddlename.Text = UserInfo.middlename;
            }
        }

        private void TxtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
