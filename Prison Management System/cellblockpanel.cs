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
    public partial class cellblockpanel : Form
    {
        public cellblockpanel()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private void clear()
        {
            txtName.Text = "";
            cbStatus.Text = "";
            cbPrison.Text = "";
        }

        public void refresh()
        {
            sql = "SELECT cb.prison_name as 'Prison', cb.cellname as 'Name', cb.status as 'Status', " +
                "COUNT(DISTINCT ot.pdlid) as 'TotalPeople' FROM tbl_cellblock cb LEFT JOIN " +
                "tbl_pdlinfo ot ON cb.cellname = ot.celllocation GROUP BY  cb.prison_name, cb.cellname, cb.status";
            /*SELECT cb.prison_name as 'Prison', cb.name as 'Name', cb.status as 'Status', " +
            "       p.TotalPeople " +
            "FROM tbl_cellblock cb " +
            "LEFT JOIN tbl_booking p ON cb.cellblock_id = p.cellblock_id*/
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void Cellblockpanel_Load(object sender, EventArgs e)
        {
            refresh();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_prison";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbPrison.Items.Add(rd.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbPrison_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
            cbStatus.Text == ""||
            cbPrison.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_cellblock(prison_name,name,status) VALUES ('"+ cbPrison.Text +"','" + txtName.Text + "','" + cbStatus.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                clear();
                refresh();
            }
        }

        private void retrieve_data()
        {
            sql = "SELECT * FROM tbl_cellblock WHERE id='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                cbPrison.Text = config.dt.Rows[0].Field<string>("prison_name").ToString(); ;
                txtName.Text = config.dt.Rows[0].Field<string>("name").ToString();
                cbStatus.Text = config.dt.Rows[0].Field<string>("status").ToString();
                //tpAddEmp.Text = "Update Employee";
            }
            else
            {
                clear();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this CellBlock permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_cellblock WHERE id='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'";
                config.Load_DTG(sql, bunifuCustomDataGrid1);
                MessageBox.Show("User has been Remove!");

                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                refresh();
            }
        }
    }
}
