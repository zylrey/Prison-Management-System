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
    public partial class reportspanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public reportspanel()
        {
            InitializeComponent();
        }

        private void Reportspanel_Load(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', fullname as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', mugshot as 'Mugshot', confirmation as 'Confirmation' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', fullname as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color', mugshot as 'Mugshot', confirmation as 'Confirmation' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }
    }
}
