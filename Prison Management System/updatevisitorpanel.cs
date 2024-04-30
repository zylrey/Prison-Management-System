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
    public partial class updatevisitorpanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public updatevisitorpanel()
        {
            InitializeComponent();
        }

        public static updatevisitorpanel frm;
        public static updatevisitorpanel getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new updatevisitorpanel();
                }
                return frm;
            }
        }

        private void Updatevisitorpanel_Load(object sender, EventArgs e)
        {
            txtid.Text = visitorpanel.selectedrow.Cells[0].Value.ToString();
            cbInmate.Text = visitorpanel.selectedrow.Cells[1].Value.ToString();
            txtFullname.Text = visitorpanel.selectedrow.Cells[2].Value.ToString();
            txtContact.Text = visitorpanel.selectedrow.Cells[3].Value.ToString();
            txtRelation.Text = visitorpanel.selectedrow.Cells[4].Value.ToString();
            cboOIC.Text = visitorpanel.selectedrow.Cells[5].Value.ToString();

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_booking";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbInmate.Items.Add(rd.GetString("fullname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery2 = "SELECT * FROM tbl_user";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery2, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboOIC.Items.Add(rd.GetString("firstname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        public void clear()
        {
            txtFullname.Clear();
            txtContact.Clear();
            txtRelation.Clear();
            cboOIC.Text = "";
            cbInmate.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" ||
            txtContact.Text == "" ||
            txtRelation.Text == "" ||
            cboOIC.Text == "" ||
            cbInmate.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "UPDATE tbl_visitlist SET inmate = '" +cbInmate.Text+ "', fullname = '" + txtFullname.Text 
                    + "', contact = '" + txtContact.Text + "', relation = '" + txtRelation.Text + "', oic = '" + cboOIC.Text 
                    + "' WHERE id = '" +txtid.Text+ "'";
                config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
                clear();
            }
        }
    }
}
