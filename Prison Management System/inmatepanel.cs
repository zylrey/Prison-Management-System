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
    public partial class inmatepanel : Form
    {
        public inmatepanel()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private void Inmatepanel_Load(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(firstname, ' ', Middlename, ' ', Lastname) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', residenceadd as 'Residence Address',maritalstatus as 'Marital Status',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', bloodtype as 'Bloodtype', confirmation as 'Confirmation' FROM tbl_bookings WHERE confirmation = 'Detained' AND " +
            " firstname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);

            /**
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT fullname FROM tbl_booking WHERE confirmation = 'Detained'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtSearch.Text = rd["fullname"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
            sql = "SELECT date_created as 'Date Created',code as 'Code' ,concat(lastname,', ',firstname,' ',  middlename) as 'Full Inmate Name' " +
            ", status as 'Status' FROM tbl_inmatelist";
            config.Load_DTG(sql,DataGridView1);
            funct.ResponsiveDtg(DataGridView1);

            
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_cellblock";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbCellblock.Items.Add(rd.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_crime";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbCrime.Items.Add(rd.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            /**
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this User Details permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_inmatelist WHERE code='" + DataGridView1.CurrentRow.Cells[1].Value + "'";
                config.Load_DTG(sql, DataGridView1);
                MessageBox.Show("User has been Remove!");

                sql = "SELECT date_created as 'Date Created',code as 'Code' ,concat(lastname,', ',firstname,' ',  middlename) as 'Full Inmate Name' " +
                ", status as 'Status' FROM tbl_inmatelist";
                config.Load_DTG(sql, DataGridView1);
                funct.ResponsiveDtg(DataGridView1);
            }
            else if (dialogResult == DialogResult.No)
            {
                sql = "SELECT date_created as 'Date Created',code as 'Code' ,concat(lastname,', ',firstname,' ',  middlename) as 'Full Inmate Name' " +
                ", status as 'Status' FROM tbl_inmatelist";
                config.Load_DTG(sql, DataGridView1);
                funct.ResponsiveDtg(DataGridView1);
            } */
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new addinmatepanel().Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            new addbooking().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewinmatepanel frm = new viewinmatepanel();

            sql = "SELECT * FROM tbl_bookings WHERE firstname='" + txtSearch.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                frm.lblFirstname.Text = config.dt.Rows[0].Field<string>("firstname").ToString();
                frm.lblNI.Text = config.dt.Rows[0].Field<string>("ni").ToString();
                frm.lblAddress.Text = config.dt.Rows[0].Field<string>("address").ToString();
                frm.lblDOC.Text = config.dt.Rows[0].Field<string>("doc").ToString();
                frm.lblAO.Text = config.dt.Rows[0].Field<string>("ao").ToString();
                frm.lblCO.Text = config.dt.Rows[0].Field<string>("co").ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            new addbooking().Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            /*
            viewinmatepanel frm = new viewinmatepanel();

            sql = "SELECT * FROM tbl_booking WHERE fullname='" + txtSearch.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                frm.lblFirstname.Text = config.dt.Rows[0].Field<string>("fullname").ToString();
                frm.lblNI.Text = config.dt.Rows[0].Field<string>("ni").ToString();
                frm.lblAddress.Text = config.dt.Rows[0].Field<string>("address").ToString();
                frm.lblDOC.Text = config.dt.Rows[0].Field<string>("doc").ToString();
                frm.lblAO.Text = config.dt.Rows[0].Field<string>("ao").ToString();
                frm.lblCO.Text = config.dt.Rows[0].Field<string>("co").ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nothing");
            } */
        }

        private void CboSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(firstname, ' ', Middlename, ' ', Lastname) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', residenceadd as 'Residence Address',maritalstatus as 'Marital Status',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', bloodtype as 'Bloodtype', confirmation as 'Confirmation' FROM tbl_bookings WHERE confirmation = 'Detained' AND" +
            " firstname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(firstname, ' ', Middlename, ' ', Lastname) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', residenceadd as 'Residence Address',maritalstatus as 'Marital Status',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', bloodtype as 'Bloodtype', confirmation as 'Confirmation' FROM tbl_bookings WHERE confirmation = 'Detained' AND " +
            " firstname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            new addBooking2().Show();
        }
    }
}
