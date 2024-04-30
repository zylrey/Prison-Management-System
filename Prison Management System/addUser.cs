using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prison_Management_System
{
    public partial class addUser : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;
        public addUser()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            txtLastname.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                unview.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void Unview_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                view.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
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
            else if (cbType.Text == "Warden")
            {
                sql = "INSERT INTO tbl_user(firstname,middlename,lastname,username,password,type) VALUES ('" + txtFirstname.Text + "','" + txtMiddlename.Text + "', '" + txtLastname.Text +
                "','" + txtUsername.Text + "','" + txtPassword.Text + "', '" + cbType.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                cbType.Text = "";
                clear();
            }
            else if (cbType.Text == "Jail Officer")
            {
                sql = "INSERT INTO tbl_user(firstname,middlename,lastname,username,password,type) VALUES ('" + txtFirstname.Text + "','" + txtMiddlename.Text + "', '" + txtLastname.Text +
                "','" + txtUsername.Text + "','" + txtPassword.Text + "', '" + cbType.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                cbType.Text = "";

                sql = "INSERT INTO tbl_jailofficer(firstname,middlename,lastname,username,password,type) VALUES ('" + txtFirstname.Text + "','" + txtMiddlename.Text + "', '" + txtLastname.Text +
                "','" + txtUsername.Text + "','" + txtPassword.Text + "', '" + cbType.Text + "')";
                config.Execute_Query(sql);
                cbType.Text = "";
                clear();
            }
            else if (cbType.Text == "Nurse")
            {
                sql = "INSERT INTO tbl_user(firstname,middlename,lastname,username,password,type) VALUES ('" + txtFirstname.Text + "','" + txtMiddlename.Text + "', '" + txtLastname.Text +
                "','" + txtUsername.Text + "','" + txtPassword.Text + "', '" + cbType.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                cbType.Text = "";
                clear();
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
