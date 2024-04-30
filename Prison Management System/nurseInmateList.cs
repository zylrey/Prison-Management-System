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
    public partial class nurseInmateList : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;

        public nurseInmateList()
        {
            InitializeComponent();
        }

        private void NurseInmateList_Load(object sender, EventArgs e)
        {
            sql = "SELECT bookingid as 'PDL Identification', firstname as 'First Name', middlename as 'Middle Name', lastname as 'Last Name', sex as 'Sex',birth as 'Birthday', address as 'Address',maritalstatus as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color' FROM tbl_bookings WHERE confirmation = 'Detained' ";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT bookingid as 'PDL Identification', firstname as 'First Name', middlename as 'Middle Name', lastname as 'Last Name', sex as 'Sex',birth as 'Birthday', address as 'Address',maritalstatus as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color' FROM tbl_bookings WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = DataGridView1.Rows[e.RowIndex];
                viewInmateHealth.getData.ShowDialog();
            }
        }
    }
}
