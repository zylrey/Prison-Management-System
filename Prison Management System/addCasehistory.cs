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
    public partial class addCasehistory : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public string id { get; set; }
        private string firname;
        private string lasname;

        public addCasehistory()
        {
            InitializeComponent();
        }

        private void AddCasehistory_Load(object sender, EventArgs e)
        {

            txtId.Text = id;

            int maxnum = int.Parse("999999999");
            Random rnd = new Random();
            int randomnum = rnd.Next(0, maxnum);

            txtCaseNum.Text = randomnum.ToString();


            //-----------------DATE TIME PICKER FORMAT (PERMI NAKO MALIMTAN)
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM/dd/yyyy";

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT name FROM tbl_crime";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboCrime.Items.Add(rd.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cboEscort.Text = globals.type + "  " + globals.first_name;
            cboEscort.Enabled = false;

            txtCaseNum.Enabled = false;
            txtId.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCaseNum.Text == "" ||
                cboCrime.Text == "" ||
                cboCourt.Text == "" ||
                txtJudge.Text == "" ||
                cboEscort.Text == "" ||
            cboStatus.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_casehistory(id,casenum,crime,court,judge,status,escort,date) VALUES ('" + txtId.Text + "','" + txtCaseNum.Text + "'" +
                    ",'" + cboCrime.Text + "','" + cboCourt.Text + "','" + txtJudge.Text + "','" + cboStatus.Text + "','" + cboEscort.Text + "','" + dtpDate.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                txtCaseNum.Clear();
                cboCrime.Text = "";
                cboCourt.Text = "";
                txtJudge.Clear();
                cboStatus.Text = "";
                cboEscort.Text = "";
                this.Hide();
            }
        }
    }
}
