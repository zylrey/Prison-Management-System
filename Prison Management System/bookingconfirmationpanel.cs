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
    public partial class bookingconfirmationpanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;

        public bookingconfirmationpanel()
        {
            InitializeComponent();
        }

        private void Bookingconfirmationpanel_Load(object sender, EventArgs e)
        {
            sql = "SELECT bookingid as 'ID', CONCAT(firstname, ' ', Middlename, ' ', Lastname) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', residenceadd as 'Residence Address',maritalstatus as 'Marital Status',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', bloodtype as 'Bloodtype', confirmation as 'Confirmation' FROM tbl_bookings WHERE confirmation = 'Forwarded' AND " +
            " firstname LIKE '%" + txtSearch.Text + "%' AND lastname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', fullname as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', mugshot as 'Mugshot', confirmation as 'Confirmation' FROM tbl_booking WHERE confirmation = 'Forwarded' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = bunifuCustomDataGrid1.Rows[e.RowIndex];
                confirmBooking.getData.ShowDialog();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomDataGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = bunifuCustomDataGrid1.Rows[e.RowIndex];
                confirmBooking.getData.ShowDialog();
            }
        }
    }
}
