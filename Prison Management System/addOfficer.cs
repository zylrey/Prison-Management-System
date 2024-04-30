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
    public partial class addOfficer : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public addOfficer()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtName.Text = "";
            cboStation.Text = "";
        }

        public void refresh()
        {
            sql = "SELECT id as 'ID', name as 'Officer Name',station as 'Police Station' FROM tbl_officer";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
            cboStation.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_officer(name,station) VALUES ('" + txtName.Text + "','" + cboStation.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                clear();
                refresh();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tbl_officer WHERE id='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtName.Text = config.dt.Rows[0].Field<string>("Name").ToString();
                cboStation.Text = config.dt.Rows[0].Field<string>("station").ToString();
                //tpAddEmp.Text = "Update Employee";
            }
            else
            {
                clear();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Crime permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_officer WHERE id='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
                config.Load_DTG(sql, DataGridView1);
                MessageBox.Show("User has been Remove!");

                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                refresh();
            }
        }

        private void AddOfficer_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
