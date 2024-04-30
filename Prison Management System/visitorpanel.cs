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
    public partial class visitorpanel : Form
    {
        public visitorpanel()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;

        private void Visitorpanel_Load(object sender, EventArgs e)
        {
            refresh();
            /**
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_inmatelist";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbInmate.Items.Add(rd.GetString("lastname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this User Details permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_visitlist WHERE id='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'";
                config.Load_DTG(sql, bunifuCustomDataGrid1);
                MessageBox.Show("User has been Remove!");

                sql = "SELECT id as 'ID', inmate as 'Inmate' ,fullname as 'Visitor Name' " +
            ", contact as 'Contact #', relation as 'Relation',oic as 'Officer In-charge' FROM tbl_visitlist";
                config.Load_DTG(sql, bunifuCustomDataGrid1);
                funct.ResponsiveDtg(bunifuCustomDataGrid1);
            }
            else if (dialogResult == DialogResult.No)
            {
                sql = "SELECT date_created as 'Date Created',inmate_id as 'Inmate' ,fullname as 'Visitor Name' " +
                ", contact as 'Contact #' FROM tbl_visitlist";
                config.Load_DTG(sql, bunifuCustomDataGrid1);
                funct.ResponsiveDtg(bunifuCustomDataGrid1);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', inmate as 'Inmate' ,fullname as 'Visitor Name' " +
            ", contact as 'Contact #', relation as 'Relation',oic as 'Officer In-charge' FROM tbl_visitlist" +
            " WHERE fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new addvisitorpanel().Show();
        }
        /**
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtVname.Text == "" ||
            txtContact.Text == "" ||
            txtRelation.Text == "" ||
            cbInmate.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_visitlist(inmate_id,fullname,contact,relation) VALUES ('" + cbInmate.Text + "','" + txtVname.Text + "','" + txtContact.Text + "', '" + txtRelation.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                clear();
                refresh();
            }
        } */
        /**
        private void clear()
        {
            txtVname.Text = "";
            txtContact.Text = "";
            txtRelation.Text = "";
            cbInmate.Text = "";
        } */

        public void refresh()
        {
            sql = "SELECT id as 'ID', inmate as 'Inmate' ,fullname as 'Visitor Name' " +
            ", contact as 'Contact #', relation as 'Relation',oic as 'Officer In-charge' FROM tbl_visitlist";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            viewvisitorpanel frm = new viewvisitorpanel();

            sql = "SELECT * FROM tbl_visitlist WHERE id='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                frm.lblinmate.Text = config.dt.Rows[0].Field<string>("inmate").ToString();
                frm.lblfullname.Text = config.dt.Rows[0].Field<string>("fullname").ToString();
                frm.lblcontact.Text = config.dt.Rows[0].Field<string>("contact").ToString();
                frm.lblrelation.Text = config.dt.Rows[0].Field<string>("relation").ToString();
                frm.lbloic.Text = config.dt.Rows[0].Field<string>("oic").ToString();
                frm.ShowDialog();
                //tpAddEmp.Text = "Update Employee";
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void retrieve_data()
        {
            sql = "SELECT * FROM tbl_visitlist WHERE inmate_id='" + bunifuCustomDataGrid1.CurrentRow.Cells[1].Value + "'";
            config.singleResult(sql);

            /**
            if (config.dt.Rows.Count > 0)
            {
                txtVname.Text = config.dt.Rows[0].Field<string>("fullname").ToString();
                txtContact.Text = config.dt.Rows[0].Field<string>("contact").ToString();
                txtRelation.Text = config.dt.Rows[0].Field<string>("relation").ToString();
                //tpAddEmp.Text = "Update Employee";
            }
            else
            {
                clear();
            }*/


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            new addvisitorpanel().Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedrow = bunifuCustomDataGrid1.Rows[e.RowIndex];
                updatevisitorpanel.getData.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            new addvisitorpanel().Show();
        }
    }
}
