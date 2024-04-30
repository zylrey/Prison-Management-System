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
    public partial class frmInmateListPanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;
        public frmInmateListPanel()
        {
            InitializeComponent();
        }

        private void FrmInmateListPanel_Load(object sender, EventArgs e)
        {
            /**
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color',ni as 'Name of Institution' " +
                ", aci as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer', mugshot as 'PDL Mugshot', sc as 'Security Classification', maiden as 'Maiden Name'" +
                ", affiliation as 'Affiliation/Gang Mebership',returndate as 'Return Date', da as 'Date Arrested', dc as 'Date Committed', lenght as 'Length of Stay', raddress as 'Residence Address'" +
                ", alias as 'Alias', dmark as 'Distinguisting Marks', cell as 'Cell Location', edr as 'Expected Date of Release', edrg as 'Expected Date of Release with GCTA', cta as 'Credited Time Allowance'" +
                ", cpi as 'CPI', paddress as 'Permanent Address', icategory as 'Inmate Category', istatus as 'Inmate Status', njail as 'Name of Jail', addjail as 'Address of Jail'" +
                ", rjail as 'Jail Region', wjail as 'Jail Warden', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', extension as 'Extension' FROM tbl_booking WHERE confirmation = 'Detained' ";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1); */

            sql = "SELECT bookingid as 'PDL identification', CONCAT(firstname,' ',middlename,' ',lastname) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',maritalstatus as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color' FROM tbl_bookings WHERE confirmation = 'Detained' ";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void BunifuCustomDataGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = bunifuCustomDataGrid1.Rows[e.RowIndex];
                viewinmateinfo.getData.ShowDialog();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }
    }
}
