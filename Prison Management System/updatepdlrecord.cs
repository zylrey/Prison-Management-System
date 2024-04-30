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
    public partial class updatepdlrecord : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public updatepdlrecord()
        {
            InitializeComponent();
        }

        public static updatepdlrecord frm;
        public static updatepdlrecord getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new updatepdlrecord();
                }
                return frm;
            }
        }

        private void Updatepdlrecord_Load(object sender, EventArgs e)
        {
            txtId.Text = inmatelistpanel.selectedrow.Cells[0].Value.ToString();
            txtFname.Text = inmatelistpanel.selectedrow.Cells[1].Value.ToString();
            cboSex.Text = inmatelistpanel.selectedrow.Cells[2].Value.ToString();
            dtpBirth.Text = inmatelistpanel.selectedrow.Cells[3].Value.ToString();
            txtAddress.Text = inmatelistpanel.selectedrow.Cells[4].Value.ToString();
            cboMarital.Text = inmatelistpanel.selectedrow.Cells[5].Value.ToString();
            txtComplexion.Text = inmatelistpanel.selectedrow.Cells[6].Value.ToString();
            txtEyecolor.Text = inmatelistpanel.selectedrow.Cells[7].Value.ToString();
            cboNI.Text = inmatelistpanel.selectedrow.Cells[8].Value.ToString();
            txtACI.Text = inmatelistpanel.selectedrow.Cells[9].Value.ToString();
            dtpCommitted.Text = inmatelistpanel.selectedrow.Cells[10].Value.ToString();
            cboAO.Text = inmatelistpanel.selectedrow.Cells[11].Value.ToString();
            cboCO.Text = inmatelistpanel.selectedrow.Cells[12].Value.ToString();
            txtMugshot.Text = inmatelistpanel.selectedrow.Cells[13].Value.ToString();
            txtSecurity.Text = inmatelistpanel.selectedrow.Cells[14].Value.ToString();
            txtMaiden.Text = inmatelistpanel.selectedrow.Cells[15].Value.ToString();
            txtAffiliation.Text = inmatelistpanel.selectedrow.Cells[16].Value.ToString();
            dtpReturn.Text = inmatelistpanel.selectedrow.Cells[17].Value.ToString();
            dtpArrested.Text = inmatelistpanel.selectedrow.Cells[18].Value.ToString();
            dtpCommitted.Text = inmatelistpanel.selectedrow.Cells[19].Value.ToString();
            txtLength.Text = inmatelistpanel.selectedrow.Cells[20].Value.ToString();
            txtRAddress.Text = inmatelistpanel.selectedrow.Cells[21].Value.ToString();
            txtAlias.Text = inmatelistpanel.selectedrow.Cells[22].Value.ToString();
            txtMarks.Text = inmatelistpanel.selectedrow.Cells[23].Value.ToString();
            cboLocation.Text = inmatelistpanel.selectedrow.Cells[24].Value.ToString();
            dtpEDR.Text = inmatelistpanel.selectedrow.Cells[25].Value.ToString();
            dtpEDRG.Text = inmatelistpanel.selectedrow.Cells[26].Value.ToString();
            txtCTA.Text = inmatelistpanel.selectedrow.Cells[27].Value.ToString();
            txtCPI.Text = inmatelistpanel.selectedrow.Cells[28].Value.ToString();
            txtPAddress.Text = inmatelistpanel.selectedrow.Cells[29].Value.ToString();
            cboCategory.Text = inmatelistpanel.selectedrow.Cells[30].Value.ToString();
            cboStatus.Text = inmatelistpanel.selectedrow.Cells[31].Value.ToString();
            cboNJail.Text = inmatelistpanel.selectedrow.Cells[32].Value.ToString();
            cboAJail.Text = inmatelistpanel.selectedrow.Cells[33].Value.ToString();
            cboRJail.Text = inmatelistpanel.selectedrow.Cells[34].Value.ToString();
            cboWJail.Text = inmatelistpanel.selectedrow.Cells[35].Value.ToString();

            sql = "SELECT * FROM tbl_booking WHERE id = '" + txtId.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                pbMugshot.ImageLocation = Application.StartupPath + "//InmatePhoto//" + config.dt.Rows[0].Field<string>("mugshot").ToString();
            }
            else
            {
                pbMugshot.ImageLocation = Application.StartupPath + "//InmatePhoto//no_image.png";
            }

            btnSave.Enabled = false;

            txtSecurity.Enabled = false;
            txtMaiden.Enabled = false;
            txtAffiliation.Enabled = false;
            dtpReturn.Enabled = false;
            dtpArrested.Enabled = false;
            txtRAddress.Enabled = false;
            txtAlias.Enabled = false;
            txtMarks.Enabled = false;
            cboLocation.Enabled = false;
            dtpEDR.Enabled = false;
            dtpEDRG.Enabled = false;
            txtCTA.Enabled = false;
            txtCPI.Enabled = false;
            txtPAddress.Enabled = false;
            cboCategory.Enabled = false;
            cboStatus.Enabled = false;
            cboNJail.Enabled = false;
            cboAJail.Enabled = false;
            cboRJail.Enabled = false;
            cboWJail.Enabled = false;
        }

        private void DtpEDR_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpArrested.Value;
            DateTime endDate = dtpEDR.Value;

            int years = endDate.Year - startDate.Year;
            int days = endDate.Day - startDate.Day;
            int months = endDate.Month - startDate.Month;

            txtLength.Text = years.ToString() + " " + "year(s)" + " " + months.ToString() + " " + "month(s)" + " " + days.ToString() + " " + "day(s)";
            txtCPI.Text = years.ToString() + " " + "year(s)" + " " + months.ToString() + " " + "month(s)" + " " + days.ToString() + " " + "day(s)";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (txtSecurity.Text == "" ||
            txtMaiden.Text == "" ||
            txtAffiliation.Text == "" ||
            dtpReturn.Text == "" ||
            dtpArrested.Text == "" ||
            dtpCommitted.Text == "" ||
            txtLength.Text == "" ||
            txtRAddress.Text == "" ||
            txtAlias.Text == "" ||
            txtMarks.Text == "" ||
            cboLocation.Text == "" ||
            dtpEDR.Text == "" ||
            dtpEDRG.Text == "" ||
            txtCTA.Text == "" ||
            txtCPI.Text == "" ||
            txtPAddress.Text == "" ||
            cboCategory.Text == "" ||
            cboStatus.Text == "" ||
            cboNJail.Text == "" ||
            cboAJail.Text == "" ||
            cboRJail.Text == "" ||
            cboWJail.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "UPDATE tbl_booking SET sc = '" + txtSecurity.Text + "', maiden = '" + txtMaiden.Text
                    + "', affiliation = '" + txtAffiliation.Text + "', returndate = '" + dtpReturn.Text + "', da = '" + dtpArrested.Text 
                    + "', dc = '" + dtpCommitted.Text + "', lenght = '" + txtLength.Text + "', raddress = '" + txtRAddress.Text 
                    + "', alias = '" + txtAlias.Text + "', dmark = '" + txtMarks.Text + "', cell = '" + cboLocation.Text + "', edr = '" + dtpEDR.Text 
                    + "', edrg = '" + dtpEDRG.Text + "', cta = '" + txtCTA.Text + "', cpi = '" + txtCPI.Text + "', paddress = '" + txtPAddress.Text 
                    + "', icategory = '" + cboCategory.Text + "', istatus = '" + cboStatus.Text + "', njail = '" + cboNJail.Text 
                    + "', addjail = '" + cboAJail.Text + "', rjail = '" + cboRJail.Text + "', wjail = '" + cboWJail.Text + "' WHERE id = '" + txtId.Text + "'";
                config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
                btnSave.Enabled = false;
                btnEdit.Enabled = true;

                txtSecurity.Enabled = false;
                txtMaiden.Enabled = false;
                txtAffiliation.Enabled = false;
                dtpReturn.Enabled = false;
                dtpArrested.Enabled = false;
                txtRAddress.Enabled = false;
                txtAlias.Enabled = false;
                txtMarks.Enabled = false;
                cboLocation.Enabled = false;
                dtpEDR.Enabled = false;
                dtpEDRG.Enabled = false;
                txtCTA.Enabled = false;
                txtPAddress.Enabled = false;
                cboCategory.Enabled = false;
                cboStatus.Enabled = false;
                cboNJail.Enabled = false;
                cboAJail.Enabled = false;
                cboRJail.Enabled = false;
                cboWJail.Enabled = false;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btnsaved_Click(object sender, EventArgs e)
        {
            txtSecurity.Enabled = true;
            txtMaiden.Enabled = true;
            txtAffiliation.Enabled = true;
            dtpReturn.Enabled = true;
            dtpArrested.Enabled = true;
            txtRAddress.Enabled = true;
            txtAlias.Enabled = true;
            txtMarks.Enabled = true;
            cboLocation.Enabled = true;
            dtpEDR.Enabled = true;
            dtpEDRG.Enabled = true;
            txtCTA.Enabled = true;
            txtPAddress.Enabled = true;
            cboCategory.Enabled = true;
            cboStatus.Enabled = true;
            cboNJail.Enabled = true;
            cboAJail.Enabled = true;
            cboRJail.Enabled = true;
            cboWJail.Enabled = true;

            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void DtpEDRG_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
