using Bunifu.Framework.UI;
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
    public partial class addStaffPersonnel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private string fname;
        private string lname;
        public addStaffPersonnel()
        {
            InitializeComponent();
        }

        private void AddStaffPersonnel_Load(object sender, EventArgs e)
        {
            cboHistory.Enabled = false;

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_user WHERE type = 'Jail Officer'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    // Assuming "user_id" is the column name for user_id in your database
                    int userId = rd.GetInt32("user_id");
                    fname = rd.GetString("firstname");
                    lname = rd.GetString("lastname");
                    string fullName = fname + " " + lname;
                    cboName.Items.Add(new UserItem(userId, fullName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (cboName.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "UPDATE tbl_user SET currentdepartment = '"+ cboDepartment.Text +"', historydepartment = '" + cboDepartment.Text + "' WHERE user_id = '"+ txtID.Text +"'";
                config.Execute_CUD(sql, "No data save.", "Data has been updated in the database");
                cboName.Text = "";
                cboDepartment.Text = "";
            }
        }

        private void CboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Assuming you have a TextBox named textbox1
            UserItem selectedUser = (UserItem)cboName.SelectedItem;
            txtID.Text = selectedUser.UserId.ToString();
        }

        public class UserItem
        {
            public int UserId { get; set; }
            public string FullName { get; set; }

            public UserItem(int userId, string fullName)
            {
                UserId = userId;
                FullName = fullName;
            }

            public override string ToString()
            {
                return FullName;
            }
        }
    }
}
