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
using System.IO;

namespace Prison_Management_System
{
    public partial class updateHealthRecord : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static updateHealthRecord frm;
        public static updateHealthRecord getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new updateHealthRecord();
                }
                return frm;
            }
        }

        public updateHealthRecord()
        {
            InitializeComponent();
        }

        private void UpdateHealthRecord_Load(object sender, EventArgs e)
        {
            txtHealthnum.Text = viewInmateHealth.selectedrow.Cells[1].Value.ToString();
            txtIllness.Text = viewInmateHealth.selectedrow.Cells[2].Value.ToString();
            cboNurse.Text = viewInmateHealth.selectedrow.Cells[3].Value.ToString();
            txtBP.Text = viewInmateHealth.selectedrow.Cells[4].Value.ToString();
            txtRR.Text = viewInmateHealth.selectedrow.Cells[5].Value.ToString();
            txtBtype.Text = viewInmateHealth.selectedrow.Cells[6].Value.ToString();
            txtTemp.Text = viewInmateHealth.selectedrow.Cells[7].Value.ToString();
            txtPR.Text = viewInmateHealth.selectedrow.Cells[8].Value.ToString();
            txtWeight.Text = viewInmateHealth.selectedrow.Cells[9].Value.ToString();
            txtHeight.Text = viewInmateHealth.selectedrow.Cells[10].Value.ToString();
            txtId.Enabled = false;
            txtHealthnum.Enabled = false;

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT firstname FROM tbl_user WHERE type = 'Nurse'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboNurse.Items.Add("Nurse " + rd.GetString("firstname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tbl_healthrecord SET illness = '" + txtIllness.Text + "', nurse = '" + cboNurse.Text + "', bp = '" + txtBP.Text + "', rr = '" + txtRR.Text + "', btype = '" + txtBtype.Text + "', temp = '" + txtTemp.Text + "', pr = '" + txtPR.Text + "', weight = '" + txtWeight.Text + "', height = '" + txtHeight.Text + "', date = '" + DateTime.Today.ToString() + "' WHERE healthnum = '" + txtHealthnum.Text + "'";
            config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
