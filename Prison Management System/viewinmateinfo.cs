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
    public partial class viewinmateinfo : Form
    {
        private MySqlConnection con = new MySqlConnection();
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static DataGridViewRow selectedrow;

        public viewinmateinfo()
        {
            InitializeComponent();
        }

        public static viewinmateinfo frm;
        public static viewinmateinfo getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new viewinmateinfo();
                }
                return frm;
            }
        }

        private void Viewinmateinfo_Load(object sender, EventArgs e)
        {
            dtpReturn.Format = DateTimePickerFormat.Custom;
            dtpReturn.CustomFormat = "MM/dd/yyyy";

            dtpEDR.Format = DateTimePickerFormat.Custom;
            dtpEDR.CustomFormat = "MM/dd/yyyy";

            dtpEDRG.Format = DateTimePickerFormat.Custom;
            dtpEDRG.CustomFormat = "MM/dd/yyyy";

            dtpArrested.Format = DateTimePickerFormat.Custom;
            dtpArrested.CustomFormat = "MM/dd/yyyy";

            dtpConfinement.Format = DateTimePickerFormat.Custom;
            dtpConfinement.CustomFormat = "MM/dd/yyyy";

            dtpCommitted.Format = DateTimePickerFormat.Custom;
            dtpCommitted.CustomFormat = "MM/dd/yyyy";

            //--------Para makuha ang bookingID----------------------------
            txtId.Text = frmInmateListPanel.selectedrow.Cells[0].Value.ToString();


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

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");
                string query = "SELECT * FROM tbl_pdlinfo where pdlID Like'%" + txtId.Text + "%'";
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(query, con);
                MySqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    txtSecurity.Text = rd2["classification"].ToString();
                    txtMaiden.Text = rd2["maidenname"].ToString();
                    txtAffiliation.Text = rd2["gang"].ToString();
                    dtpReturn.Text = rd2["returndate"].ToString();
                    txtCTA.Text = rd2["cta"].ToString();
                    txtLength.Text = rd2["lenghtofstay"].ToString();
                    txtAlias.Text = rd2["alias"].ToString();
                    cboLocation.Text = rd2["celllocation"].ToString();
                    dtpEDR.Text = rd2["expectedrelease"].ToString();
                    dtpEDRG.Text = rd2["expectedreleasewithgcta"].ToString();
                    txtCPI.Text = rd2["cpi"].ToString();
                    cboNJail.Text = rd2["nameofjail"].ToString();
                    cboAJail.Text = rd2["jailaddress"].ToString();
                    cboRJail.Text = rd2["region"].ToString();
                    cboWJail.Text = rd2["warden"].ToString();
                    txtPlaceofArrest.Text = rd2["place"].ToString();
                    txtCircumstances.Text = rd2["circumstances"].ToString();
                    txtArresting.Text = rd2["arresting"].ToString();
                    dtpArrested.Text = rd2["arrested"].ToString();
                    dtpCommitted.Text = rd2["committed"].ToString();
                    txtStation.Text = rd2["station"].ToString();
                    txtMarks.Text = rd2["marks"].ToString();
                    dtpConfinement.Text = rd2["confinement"].ToString();
                    cboReceivingOfficer.Text = rd2["receivingofficer"].ToString();
                    txtSearchBy.Text = rd2["searchby"].ToString();
                    cboSearchBy.Text = rd2["searchby"].ToString();
                    txtProperty.Text = rd2["property"].ToString();
                    txtKind.Text = rd2["kind"].ToString();
                    cboCategory.Text = rd2["pdlcategory"].ToString();
                    cboStatus.Text = rd2["pdlstatus"].ToString();

                    lblStatus.Text = rd2["pdlstatus"].ToString();
                    lblCellLocation.Text = rd2["celllocation"].ToString();
                    lblEDR.Text = rd2["expectedrelease"].ToString();
                    lblVisit.Text = "";
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

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT cellname FROM tbl_cellblock";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboLocation.Items.Add(rd.GetString("cellname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //----------------case history-------------------------
            sql = "SELECT casenum as 'Case No.', crime as 'Offense/Crime', court as 'Court/Branch/Location', judge as 'Judge', status as 'Status', escort as 'Escorted By', date as 'Date' FROM tbl_casehistory WHERE id = '" + txtId.Text + "'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);

            //----------------Health Record------------------------
            sql = "SELECT id as 'PDLs ID', healthnum as 'Health No.', illness as 'History or Present Illness', nurse as 'Attending Nurse', bp as 'Blood Pressure', rr as 'Respiratory Rate', btype as 'Blood Type', temp as 'Temperature', pr as 'Pulse Rate', weight as 'Weight', height as 'Height', date as 'Date' FROM tbl_healthrecord WHERE id = '" + txtId.Text + "'";
            config.Load_DTG(sql, bunifuDtgHealth);

            txtId.Enabled = false;
            txtFname.Enabled = false;
            txtMname.Enabled = false;
            txtLname.Enabled = false;
            //txtExt.Enabled = false;
            cboSex.Enabled = false;
            dtpBirth.Enabled = false;
            txtAddress.Enabled = false;
            cboMarital.Enabled = false;
            txtComplexion.Enabled = false;
            txtEyecolor.Enabled = false;

            txtSecurity.Enabled = false;
            txtMaiden.Enabled = false;
            txtAffiliation.Enabled = false;
            dtpReturn.Enabled = false;
            dtpArrested.Enabled = false;
            txtAlias.Enabled = false;
            txtMarks.Enabled = false;
            cboLocation.Enabled = false;
            dtpEDR.Enabled = false;
            dtpEDRG.Enabled = false;
            txtCTA.Enabled = false;
            txtCPI.Enabled = false;
            cboCategory.Enabled = false;
            cboStatus.Enabled = false;
            cboNJail.Enabled = false;
            cboAJail.Enabled = false;
            cboRJail.Enabled = false;
            cboWJail.Enabled = false;
            txtPlaceofArrest.Enabled = false;
            txtCircumstances.Enabled = false;
            txtArresting.Enabled = false;
            txtStation.Enabled = false;
            dtpConfinement.Enabled = false;
            cboReceivingOfficer.Enabled = false;
            cboSearchBy.Enabled = false;
            txtSearchBy.Enabled = false;
            txtProperty.Enabled = false;
            txtKind.Enabled = false;

            bunifuUpdate.Enabled = false;
            //button4.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtFname.Enabled = true;
            txtMname.Enabled = true;
            txtLname.Enabled = true;
            cboSex.Enabled = true;
            dtpBirth.Enabled = true;
            txtAddress.Enabled = true;
            cboMarital.Enabled = true;
            txtComplexion.Enabled = true;
            txtEyecolor.Enabled = true;

            bunifuClose.Text = "Cancel";
            bunifuEdit.Enabled = false;
            bunifuUpdate.Enabled = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tbl_booking SET fname = '" + txtFname.Text + "', mname = '" + txtMname.Text
                    + "', lname = '" + txtLname.Text + "', sex = '" + cboSex.Text
                    + "', birth = '" + dtpBirth.Text + "', address = '" + txtAddress.Text + "', marital = '" + cboMarital.Text
                    + "', complexion = '" + txtComplexion.Text + "', eyecolor = '" + txtEyecolor.Text + "', fullname = '" + txtFname.Text + " " + txtMname.Text + " " + txtLname.Text + "' WHERE id = '" + txtId.Text + "'";
            config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
            bunifuEdit.Enabled = true;
            bunifuUpdate.Enabled = false;
            Viewinmateinfo_Load(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtSecurity.Text == "" ||
            txtMaiden.Text == "" ||
            txtAffiliation.Text == "" ||
            dtpReturn.Text == "" ||
            dtpArrested.Text == "" ||
            dtpCommitted.Text == "" ||
            txtLength.Text == "" ||
            txtAlias.Text == "" ||
            txtMarks.Text == "" ||
            cboLocation.Text == "" ||
            dtpEDR.Text == "" ||
            dtpEDRG.Text == "" ||
            txtCTA.Text == "" ||
            txtCPI.Text == "" ||
            cboCategory.Text == "" ||
            cboStatus.Text == "" ||
            cboNJail.Text == "" ||
            cboAJail.Text == "" ||
            cboRJail.Text == "" ||
            cboWJail.Text == "" ||
            cboCategory.Text == "" ||
            cboStatus.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "UPDATE tbl_booking SET sc = '" + txtSecurity.Text + "', maiden = '" + txtMaiden.Text
                    + "', affiliation = '" + txtAffiliation.Text + "', returndate = '" + dtpReturn.Text + "', da = '" + dtpArrested.Text
                    + "', dc = '" + dtpCommitted.Text + "', lenght = '" + txtLength.Text
                    + "', alias = '" + txtAlias.Text + "', dmark = '" + txtMarks.Text + "', cellname = '" + cboLocation.Text + "', edr = '" + dtpEDR.Text
                    + "', edrg = '" + dtpEDRG.Text + "', cta = '" + txtCTA.Text + "', cpi = '" + txtCPI.Text
                    + "', icategory = '" + cboCategory.Text + "', istatus = '" + cboStatus.Text + "', njail = '" + cboNJail.Text
                    + "', addjail = '" + cboAJail.Text + "', rjail = '" + cboRJail.Text + "', wjail = '" + cboWJail.Text + "' WHERE id = '" + txtId.Text + "'";
                config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");

                lblStatus.Text = cboStatus.Text;
                lblCellLocation.Text = cboLocation.Text;
                lblEDR.Text = dtpEDR.Text;

                txtSecurity.Enabled = false;
                txtMaiden.Enabled = false;
                txtAffiliation.Enabled = false;
                dtpReturn.Enabled = false;
                dtpArrested.Enabled = false;
                txtAlias.Enabled = false;
                txtMarks.Enabled = false;
                cboLocation.Enabled = false;
                dtpEDR.Enabled = false;
                dtpEDRG.Enabled = false;
                txtCTA.Enabled = false;
                cboCategory.Enabled = false;
                cboStatus.Enabled = false;
                cboNJail.Enabled = false;
                cboAJail.Enabled = false;
                cboRJail.Enabled = false;
                cboWJail.Enabled = false;

                //button4.Enabled = false;
                //button3.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtSecurity.Enabled = true;
            txtMaiden.Enabled = true;
            txtAffiliation.Enabled = true;
            dtpReturn.Enabled = true;
            dtpArrested.Enabled = true;
            txtAlias.Enabled = true;
            txtMarks.Enabled = true;
            cboLocation.Enabled = true;
            dtpEDR.Enabled = true;
            dtpEDRG.Enabled = true;
            txtCTA.Enabled = true;
            cboCategory.Enabled = true;
            cboStatus.Enabled = true;
            cboNJail.Enabled = true;
            cboAJail.Enabled = true;
            cboRJail.Enabled = true;
            cboWJail.Enabled = true;

            //button3.Enabled = false;
            //button4.Enabled = true;
        }

        private void DtpEDR_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpArrested.Value;
            DateTime endDate = dtpEDR.Value;

            // Calculate the difference in years, months, and days
            int years = endDate.Year - startDate.Year;
            int months = endDate.Month - startDate.Month;
            int days = endDate.Day - startDate.Day;

            // Adjust for negative differences
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(endDate.Year, endDate.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            // Display the result in the specified format
            string formattedLength = startDate.ToString("MM/dd/yyyy") + " to " + endDate.ToString("MM/dd/yyyy");
            string formattedCPI = years.ToString() + " year(s), " + months.ToString() + " month(s), " + days.ToString() + " day(s)";

            txtLength.Text = formattedLength;
            txtCPI.Text = formattedCPI;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT casenum as 'Case No.', crime as 'Offense/Crime', court as 'Court/Branch/Location', judge as 'Judge', status as 'Status', escort as 'Escorted By' FROM tbl_casehistory WHERE id = '" + txtId.Text + "'";
            config.Load_DTG(sql, bunifuCustomDataGrid1);

            sql = "SELECT id as 'PDLs ID', healthnum as 'Health No.', illness as 'History or Present Illness', nurse as 'Attending Nurse', bp as 'Blood Pressure', rr as 'Respiratory Rate', btype as 'Blood Type', temp as 'Temperature', pr as 'Pulse Rate', weight as 'Weight', height as 'Height', date as 'Date' FROM tbl_healthrecord WHERE id = '" + txtId.Text + "'";
            config.Load_DTG(sql, bunifuDtgHealth);
        }

        private void DtgCaseHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = bunifuCustomDataGrid1.Rows[e.RowIndex];
                updateCaseHistory.getData.ShowDialog();
            }
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
                selectedrow = bunifuDtgHealth.Rows[e.RowIndex];
                updateHealthRecord.getData.ShowDialog();
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtFname.Enabled = true;
            txtMname.Enabled = true;
            txtLname.Enabled = true;
            cboSex.Enabled = true;
            dtpBirth.Enabled = true;
            txtAddress.Enabled = true;
            cboMarital.Enabled = true;
            txtComplexion.Enabled = true;
            txtEyecolor.Enabled = true;

            bunifuClose.Text = "Cancel";
            bunifuEdit.Enabled = false;
            bunifuUpdate.Enabled = true;
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            sql = "UPDATE tbl_bookings SET firstname = '" + txtFname.Text + "', middlename = '" + txtMname.Text
                    + "', lastname = '" + txtLname.Text + "', sex = '" + cboSex.Text
                    + "', birth = '" + dtpBirth.Text + "', address = '" + txtAddress.Text + "', maritalstatus = '" + cboMarital.Text
                    + "', complexion = '" + txtComplexion.Text + "', eyecolor = '" + txtEyecolor.Text + "' WHERE bookingid = '" + txtId.Text + "'";
            config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
            bunifuEdit.Enabled = true;
            bunifuUpdate.Enabled = false;
            Viewinmateinfo_Load(sender, e);
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BunifuThinButton26_Click(object sender, EventArgs e)
        {
            txtSecurity.Enabled = true;
            txtMaiden.Enabled = true;
            txtAffiliation.Enabled = true;
            dtpReturn.Enabled = true;
            txtAlias.Enabled = true;
            cboLocation.Enabled = true;
            dtpEDR.Enabled = true;
            dtpEDRG.Enabled = true;
            txtCTA.Enabled = true;
            cboCategory.Enabled = true;
            cboStatus.Enabled = true;
            cboNJail.Enabled = true;
            cboAJail.Enabled = true;
            cboRJail.Enabled = true;
            cboWJail.Enabled = true;

            //button3.Enabled = false;
            //button4.Enabled = true;
        }

        private void BunifuBtnupdate_Click(object sender, EventArgs e)
        {
            if (txtSecurity.Text == "" ||
            txtAffiliation.Text == "" ||
            dtpReturn.Text == "" ||
            dtpArrested.Text == "" ||
            dtpCommitted.Text == "" ||
            txtLength.Text == "" ||
            txtAlias.Text == "" ||
            txtMarks.Text == "" ||
            cboLocation.Text == "" ||
            dtpEDR.Text == "" ||
            dtpEDRG.Text == "" ||
            txtCTA.Text == "" ||
            txtCPI.Text == "" ||
            cboCategory.Text == "" ||
            cboStatus.Text == "" ||
            cboNJail.Text == "" ||
            cboAJail.Text == "" ||
            cboRJail.Text == "" ||
            cboWJail.Text == "" ||
            cboCategory.Text == "" ||
            cboStatus.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "UPDATE tbl_pdlinfo SET classification = '" + txtSecurity.Text + "', maidenname = '" + txtMaiden.Text
                    + "', gang = '" + txtAffiliation.Text + "', returndate = '" + dtpReturn.Text + "', cta = '" + txtCTA.Text
                    + "', lenghtofstay = '" + txtLength.Text + "', alias = '" + txtAlias.Text
                    + "', celllocation = '" + cboLocation.Text + "', marks = '" + txtMarks.Text + "', expectedrelease = '" + dtpEDR.Text + "', expectedreleasewithgcta = '" + dtpEDRG.Text
                    + "', cpi = '" + txtCPI.Text + "', pdlcategory = '" + cboCategory.Text + "', pdlstatus = '" + cboStatus.Text
                    + "', place = '" + txtPlaceofArrest.Text + "', circumstances = '" + txtCircumstances.Text + "', arresting = '" + txtArresting.Text
                    + "', arrested = '" + dtpArrested.Text + "', committed = '" + dtpCommitted.Text + "', station = '" + txtStation.Text + "'" +
                    ", nameofjail = '" + cboNJail.Text + "', jailaddress = '" + cboAJail.Text + "', confinement = '" + dtpConfinement.Text + "'" +
                    ", receivingofficer = '" + cboReceivingOfficer.Text + "', searchby = '" + cboSearchBy.Text + "', region = '" + cboRJail.Text + "'" +
                    ", warden = '" + cboWJail.Text + "' WHERE pdlid = '" + txtId.Text + "'";
                config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");

                lblStatus.Text = cboStatus.Text;
                lblCellLocation.Text = cboLocation.Text;
                lblEDR.Text = dtpEDR.Text;

                txtSecurity.Enabled = false;
                txtMaiden.Enabled = false;
                txtAffiliation.Enabled = false;
                dtpReturn.Enabled = false;
                dtpArrested.Enabled = false;
                txtAlias.Enabled = false;
                txtMarks.Enabled = false;
                cboLocation.Enabled = false;
                dtpEDR.Enabled = false;
                dtpEDRG.Enabled = false;
                txtCTA.Enabled = false;
                cboCategory.Enabled = false;
                cboStatus.Enabled = false;
                cboNJail.Enabled = false;
                cboAJail.Enabled = false;
                cboRJail.Enabled = false;
                cboWJail.Enabled = false;

               //button4.Enabled = false;
               // button3.Enabled = true;
            }
        }

        private void BunifuBtnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            addCasehistory frm = new addCasehistory();
            frm.id = txtId.Text;
            frm.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            addCasehistory frm = new addCasehistory();
            frm.id = txtId.Text;
            frm.ShowDialog();
        }

        private void BunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton23_Click_1(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            addHealthRecord frm = new addHealthRecord();
            frm.id = txtId.Text;
            frm.ShowDialog();
        }
    }
}
