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
    public partial class prisonpanel : Form
    {
        public prisonpanel()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
            cbStatus.Text == "" )
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_prison(name,status) VALUES ('" + txtName.Text + "','" + cbStatus.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                clear();
                //refresh();
            }
        }

        private void clear()
        {
            txtName.Text = "";
            cbStatus.Text = "";
        }

        public void malecount()
        {
            sql = "SELECT id as 'ID', name as 'Name',status as 'Status', COUNT(*) as 'Total' FROM tbl_prison WHERE name = 'Mens Prison'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        public void femalecount()
        {
            sql = "SELECT id as 'ID', name as 'Name',status as 'Status', COUNT(*) as 'Total' FROM tbl_prison WHERE name = 'Womens Prison'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void retrieve_data()
        {
            sql = "SELECT * FROM tbl_prison WHERE id='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtName.Text = config.dt.Rows[0].Field<string>("Name").ToString();
                cbStatus.Text = config.dt.Rows[0].Field<string>("Status").ToString();
                
            }
            else
            {
                clear();
            }
        }

        private void Prisonpanel_Load(object sender, EventArgs e)
        {
            malecount();
            femalecount();
            //refresh();
            double totalMen = Convert.ToDouble(config.totalMen());
            lblMen.Text = totalMen.ToString();
            double totalWomen = Convert.ToDouble(config.totalWomen());
            lblWomen.Text = totalWomen.ToString();
            double totalInmate = Convert.ToDouble(config.totalInmate());
            lblTotal.Text = totalInmate.ToString();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Prison permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_prison WHERE id='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
                config.Load_DTG(sql, DataGridView1);
                MessageBox.Show("User has been Remove!");

                //refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                //refresh();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT name as 'Name',status as 'Status' FROM tbl_prison WHERE name LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Prisoncount_Click(object sender, EventArgs e)
        {

        }
    }
}
