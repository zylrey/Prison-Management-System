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
    public partial class updateStaffPersonnel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private string fname;
        private string lname;
        public updateStaffPersonnel()
        {
            InitializeComponent();
        }

        private void UpdateStaffPersonnel_Load(object sender, EventArgs e)
        {
            cboName.Enabled = false;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (cboName.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "UPDATE tbl_user SET currentdepartment = '" + cboDepartment.Text + "' WHERE user_id = '" + txtID.Text + "'";
                config.Execute_CUD(sql, "No data save.", "Data has been updated in the database");
                cboName.Text = "";
                cboDepartment.Text = "";
            }
        }
    }
}
