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
    public partial class updateCaseHistory : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static updateCaseHistory frm;
        public static updateCaseHistory getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new updateCaseHistory();
                }
                return frm;
            }
        }

        public updateCaseHistory()
        {
            InitializeComponent();
        }

        private void UpdateCaseHistory_Load(object sender, EventArgs e)
        {
            txtCaseNum.Text = viewinmateinfo.selectedrow.Cells[0].Value.ToString();
            txtCaseNum.Enabled = false;
            /**
            cboCrime.Text = viewinmateinfo.selectedrow.Cells[1].Value.ToString();
            cboCourt.Text = viewinmateinfo.selectedrow.Cells[2].Value.ToString();
            txtJudge.Text = viewinmateinfo.selectedrow.Cells[3].Value.ToString();
            cboStatus.Text = viewinmateinfo.selectedrow.Cells[4].Value.ToString();

            txtCaseNum.Enabled = false;
            cboCrime.Enabled = false;
            cboCourt.Enabled = false;
            txtJudge.Enabled = false; 

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT firstname FROM tbl_user WHERE type = 'Jail Officer'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboEscort.Items.Add("Jail Officer " + rd.GetString("firstname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tbl_casehistory SET status = '" + cboStatus.Text + "' WHERE casenum = '" + txtCaseNum.Text + "'";
            config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
