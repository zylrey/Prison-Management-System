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
    public partial class addHealthRecord : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public string id { get; set; }
        public addHealthRecord()
        {
            InitializeComponent();
        }

        private void AddHealthRecord_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtId.Enabled = false;
            txtHealthnum.Enabled = false;

            int maxnum = int.Parse("999999999");
            Random rnd = new Random();
            int randomnum = rnd.Next(0, maxnum);

            txtHealthnum.Text = randomnum.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" ||
                txtIllness.Text == "" ||
                cboNurse.Text == "" ||
                txtBP.Text == "" ||
                txtRR.Text == "" ||
                txtBtype.Text == "" ||
                txtTemp.Text == "" ||
                txtWeight.Text == "" ||
                txtHeight.Text == "" ||
                txtPR.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_healthrecord(id,healthnum,illness,nurse,bp,rr,btype,temp,pr,weight,height,date) VALUES ('" + txtId.Text + "','" + txtHealthnum.Text + "','" + txtIllness.Text + "'" +
                    ",'" + cboNurse.Text + "', '" + txtBP.Text + "', '" + txtRR.Text + "', '" + txtBtype.Text + "', '" + txtTemp.Text + "', '" + txtWeight.Text + "', '" + txtHeight.Text + "', '" + txtPR.Text + "', '" + DateTime.Today.ToString() + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                cleartxt();
                this.Hide();
            }
        }

        private void cleartxt()
        {
            txtIllness.Text = "";
            cboNurse.Text = "";
            txtBP.Text = "";
            txtRR.Text = "";
            txtBtype.Text = "";
            txtTemp.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtPR.Text = "";
        }

        private void CboNurse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
