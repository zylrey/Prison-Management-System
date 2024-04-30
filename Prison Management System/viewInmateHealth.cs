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
    public partial class viewInmateHealth : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;

        public static viewInmateHealth frm;
        public static viewInmateHealth getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new viewInmateHealth();
                }
                return frm;
            }
        }
        public viewInmateHealth()
        {
            InitializeComponent();
        }

        private void PbMugshot_Click(object sender, EventArgs e)
        {

        }

        private void TxtMugshot_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewInmateHealth_Load(object sender, EventArgs e)
        {
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.CustomFormat = "MM/dd/yyyy";

            txtId.Text = nurseInmateList.selectedrow.Cells[0].Value.ToString();

            //----------------PDL basic Informations-------------------------
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");
                string query = "SELECT * FROM tbl_bookings where bookingid Like'%" + txtId.Text + "%'";
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(query, con);
                MySqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    txtFname.Text = rd2["firstname"].ToString();
                    txtMname.Text = rd2["middlename"].ToString();
                    txtLname.Text = rd2["lastname"].ToString();
                    cboSex.Text = rd2["sex"].ToString();
                    dtpBirth.Text = rd2["birth"].ToString();
                    txtAddress.Text = rd2["address"].ToString();
                    cboMarital.Text = rd2["maritalstatus"].ToString();
                    txtComplexion.Text = rd2["complexion"].ToString();
                    txtEyecolor.Text = rd2["eyecolor"].ToString();
                    txtBP.Text = rd2["bloodtype"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sql = "SELECT * FROM tbl_pdlinfo WHERE pdlid = '" + txtId.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                pbMugshot.ImageLocation = Application.StartupPath + "//InmatePhoto//" + config.dt.Rows[0].Field<string>("mugshot").ToString();
            }
            else
            {
                pbMugshot.ImageLocation = Application.StartupPath + "//InmatePhoto//no_image.png";
            }

            //----------------Health Record------------------------
            sql = "SELECT id as 'PDLs ID', healthnum as 'Health No.', illness as 'History or Present Illness', nurse as 'Attending Nurse', bp as 'Blood Pressure', rr as 'Respiratory Rate', btype as 'Blood Type', temp as 'Temperature', pr as 'Pulse Rate', weight as 'Weight', height as 'Height', date as 'Date' FROM tbl_healthrecord WHERE id = '" + txtId.Text + "'";
            config.Load_DTG(sql, dtgHealthRecord);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            addHealthRecord frm = new addHealthRecord();
            frm.id = txtId.Text;
            frm.ShowDialog();
        }

        private void DtgHealthRecord_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = dtgHealthRecord.Rows[e.RowIndex];
                updateHealthRecord.getData.ShowDialog();
            }
        }

        private void DtgHealthRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgHealthRecord_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
