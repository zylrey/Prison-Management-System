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
    public partial class inmatelistpanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;

        public inmatelistpanel()
        {
            InitializeComponent();
        }

        private void inmatelistpanel_Load(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color',ni as 'Name of Institution' " +
                ", aci as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer', mugshot as 'PDL Mugshot', sc as 'Security Classification', maiden as 'Maiden Name'" +
                ", affiliation as 'Affiliation/Gang Mebership',returndate as 'Return Date', da as 'Date Arrested', dc as 'Date Committed', lenght as 'Length of Stay', raddress as 'Residence Address'" +
                ", alias as 'Alias', dmark as 'Distinguisting Marks', cell as 'Cell Location', edr as 'Expected Date of Release', edrg as 'Expected Date of Release with GCTA', cta as 'Credited Time Allowance'" +
                ", cpi as 'CPI', paddress as 'Permanent Address', icategory as 'Inmate Category', istatus as 'Inmate Status', njail as 'Name of Jail', addjail as 'Address of Jail'" +
                ", rjail as 'Jail Region', wjail as 'Jail Warden', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', extension as 'Extension' FROM tbl_booking WHERE confirmation = 'Detained' ";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this User Details permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_booking WHERE id='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
                config.Load_DTG(sql, DataGridView1);
                MessageBox.Show("User has been Remove!");

                sql = "SELECT id as 'ID', concat(firstname , ' ' , middlename , ' ' , lastname, ' ' , ext) as 'PDL Fullname' ,ni as 'Name of Institution' " +
            ", address as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer' FROM tbl_booking";
                config.Load_DTG(sql, DataGridView1);
                funct.ResponsiveDtg(DataGridView1);
            }
            else if (dialogResult == DialogResult.No)
            {
                sql = "SELECT id as 'ID', concat(firstname , ' ' , middlename , ' ' , lastname, ' ' , ext) as 'PDL Fullname' ,ni as 'Name of Institution' " +
            ", address as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer' FROM tbl_booking";
                config.Load_DTG(sql, DataGridView1);
                funct.ResponsiveDtg(DataGridView1);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            viewinmatepanel frm = new viewinmatepanel();

            sql = "SELECT * FROM tbl_booking WHERE id='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                frm.lblFirstname.Text = config.dt.Rows[0].Field<string>("fullname").ToString();

                frm.lblNI.Text = config.dt.Rows[0].Field<string>("ni").ToString();
                frm.lblAddress.Text = config.dt.Rows[0].Field<string>("aci").ToString();
                frm.lblDOC.Text = config.dt.Rows[0].Field<string>("doc").ToString();
                frm.lblAO.Text = config.dt.Rows[0].Field<string>("ao").ToString();
                frm.lblCO.Text = config.dt.Rows[0].Field<string>("co").ToString();
                frm.ShowDialog();
                //tpAddEmp.Text = "Update Employee";
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', fullname as 'PDL Fullname' ,ni as 'Name of Institution' " +
            ", address as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer'" +
            ", co as 'Committing Officer' FROM tbl_booking WHERE" +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void DataGridView1_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = DataGridView1.Rows[e.RowIndex];
                updatepdlrecord.getData.ShowDialog();
            }
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = DataGridView1.Rows[e.RowIndex];
                updatepdlrecord.getData.ShowDialog();
            }
        }

        private void DataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = DataGridView1.Rows[e.RowIndex];
                viewinmateinfo.getData.ShowDialog();
            }
        }

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color',ni as 'Name of Institution' " +
                ", aci as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer', mugshot as 'PDL Mugshot', sc as 'Security Classification', maiden as 'Maiden Name'" +
                ", affiliation as 'Affiliation/Gang Mebership',returndate as 'Return Date', da as 'Date Arrested', dc as 'Date Committed', lenght as 'Length of Stay', raddress as 'Residence Address'" +
                ", alias as 'Alias', dmark as 'Distinguisting Marks', cell as 'Cell Location', edr as 'Expected Date of Release', edrg as 'Expected Date of Release with GCTA', cta as 'Credited Time Allowance'" +
                ", cpi as 'CPI', paddress as 'Permanent Address', icategory as 'Inmate Category', istatus as 'Inmate Status', njail as 'Name of Jail', addjail as 'Address of Jail'" +
                ", rjail as 'Jail Region', wjail as 'Jail Warden', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', extension as 'Extension' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNew_Click_1(object sender, EventArgs e)
        {

        }

        private void BunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color',ni as 'Name of Institution' " +
                ", aci as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer', mugshot as 'PDL Mugshot', sc as 'Security Classification', maiden as 'Maiden Name'" +
                ", affiliation as 'Affiliation/Gang Mebership',returndate as 'Return Date', da as 'Date Arrested', dc as 'Date Committed', lenght as 'Length of Stay', raddress as 'Residence Address'" +
                ", alias as 'Alias', dmark as 'Distinguisting Marks', cell as 'Cell Location', edr as 'Expected Date of Release', edrg as 'Expected Date of Release with GCTA', cta as 'Credited Time Allowance'" +
                ", cpi as 'CPI', paddress as 'Permanent Address', icategory as 'Inmate Category', istatus as 'Inmate Status', njail as 'Name of Jail', addjail as 'Address of Jail'" +
                ", rjail as 'Jail Region', wjail as 'Jail Warden', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', extension as 'Extension' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void BunifuTextbox1_OnTextChange_1(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color',ni as 'Name of Institution' " +
                ", aci as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer', mugshot as 'PDL Mugshot', sc as 'Security Classification', maiden as 'Maiden Name'" +
                ", affiliation as 'Affiliation/Gang Mebership',returndate as 'Return Date', da as 'Date Arrested', dc as 'Date Committed', lenght as 'Length of Stay', raddress as 'Residence Address'" +
                ", alias as 'Alias', dmark as 'Distinguisting Marks', cell as 'Cell Location', edr as 'Expected Date of Release', edrg as 'Expected Date of Release with GCTA', cta as 'Credited Time Allowance'" +
                ", cpi as 'CPI', paddress as 'Permanent Address', icategory as 'Inmate Category', istatus as 'Inmate Status', njail as 'Name of Jail', addjail as 'Address of Jail'" +
                ", rjail as 'Jail Region', wjail as 'Jail Warden', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', extension as 'Extension' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void BunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT id as 'ID', CONCAT(fname,' ',mname,' ',lname,' ',extension) as 'PDL Fullname',sex as 'Sex',birth as 'Birthday', address as 'Address',marital as 'Marital',complexion as 'Complexion'" +
                ", eyecolor as 'Eye Color',ni as 'Name of Institution' " +
                ", aci as 'Address of Committ', doc as 'Date of Committ',ao as 'Arresting Officer', co as 'Committing Officer', mugshot as 'PDL Mugshot', sc as 'Security Classification', maiden as 'Maiden Name'" +
                ", affiliation as 'Affiliation/Gang Mebership',returndate as 'Return Date', da as 'Date Arrested', dc as 'Date Committed', lenght as 'Length of Stay', raddress as 'Residence Address'" +
                ", alias as 'Alias', dmark as 'Distinguisting Marks', cell as 'Cell Location', edr as 'Expected Date of Release', edrg as 'Expected Date of Release with GCTA', cta as 'Credited Time Allowance'" +
                ", cpi as 'CPI', paddress as 'Permanent Address', icategory as 'Inmate Category', istatus as 'Inmate Status', njail as 'Name of Jail', addjail as 'Address of Jail'" +
                ", rjail as 'Jail Region', wjail as 'Jail Warden', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', extension as 'Extension' FROM tbl_booking WHERE confirmation = 'Detained' AND " +
            " fullname LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }
    }
}
