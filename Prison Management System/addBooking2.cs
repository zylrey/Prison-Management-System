using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prison_Management_System
{
    public partial class addBooking2 : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql,sql2;
        private string fname;
        private string lname;

        public addBooking2()
        {
            InitializeComponent();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT name FROM tbl_crime";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboOffense.Items.Add(rd.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_user WHERE type = 'Jail Officer'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    fname = rd.GetString("firstname");
                    lname = rd.GetString("lastname");
                    string fullName = fname + " " + lname;
                    cboSearchBy.Items.Add(rd.GetString("type") + " " + fullName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            cboReceivingOfficer.Text = globals.type + "  " + globals.first_name;
        }

        private void Label33_Click(object sender, EventArgs e)
        {

        }

        private void TextBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label34_Click(object sender, EventArgs e)
        {

        }

        private void AddBooking2_Load(object sender, EventArgs e)
        {
            int maxnum = int.Parse("10000");
            Random rnd = new Random();
            int randomnum = rnd.Next(0, maxnum);

            txtID.Text = randomnum.ToString();
            txtPrisonno.Text = randomnum.ToString();

            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.CustomFormat = "MM/dd/yyyy";

            dtpArrested.Format = DateTimePickerFormat.Custom;
            dtpArrested.CustomFormat = "MM/dd/yyyy";

            dtpCommited.Format = DateTimePickerFormat.Custom;
            dtpCommited.CustomFormat = "MM/dd/yyyy";

            dtpConfinement.Format = DateTimePickerFormat.Custom;
            dtpConfinement.CustomFormat = "MM/dd/yyyy";


            // Populate comboBox1 with police station names
            cboStation.Items.Add("Police Station 1 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 2 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 3 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 4 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 5 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 6 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 7 (GENERAL SANTOS CITY)");
            cboStation.Items.Add("Police Station 8 (GENERAL SANTOS CITY)");

            // You can also pre-populate comboBox2 with the barangays for the first police station
            UpdateBrgyComboBox("Police Station 1");
        }

        private void BunifuBtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            txtID.Visible = false;
            txtPrisonno.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            cboReceivingOfficer.Enabled = false;

            if (cboStatus.Text == "Single")
            {
                label27.Visible = false;
                label28.Visible = false;
                txtNameofWife.Visible = false;
                txtNumberofChildren.Visible = false;
            }
            else if (cboStatus.Text == "Married")
            {
                label27.Visible = true;
                label28.Visible = true;
                txtNameofWife.Visible = true;
                txtNumberofChildren.Visible = true;
            }
            else if (cboStatus.Text == "Widowed")
            {
                label27.Visible = true;
                label28.Visible = true;
                txtNameofWife.Visible = true;
                txtNumberofChildren.Visible = true;
            }
            else if (cboStatus.Text == "Divorced")
            {
                label27.Visible = true;
                label28.Visible = true;
                txtNameofWife.Visible = true;
                txtNumberofChildren.Visible = true;
            }
            else if (cboStatus.Text == "Separated")
            {
                label27.Visible = true;
                label28.Visible = true;
                txtNameofWife.Visible = true;
                txtNumberofChildren.Visible = true;
            }
        }

        private void PbMugshot_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.JPG)|*.jpg|(*.PNG)|*.png|(*.JPEG)|*.jepg|All files|*.*";
            DialogResult rs = openFileDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txtMugshot.Text = openFileDialog1.FileName;
                pbMugshot.ImageLocation = openFileDialog1.FileName;
                pbMugshot.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PbSignature_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.JPG)|*.jpg|(*.PNG)|*.png|(*.JPEG)|*.jepg|All files|*.*";
            DialogResult rs = openFileDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txtSignature.Text = openFileDialog1.FileName;
                pbSignature.ImageLocation = openFileDialog1.FileName;
                pbSignature.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PbMarks_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.JPG)|*.jpg|(*.PNG)|*.png|(*.JPEG)|*.jepg|All files|*.*";
            DialogResult rs = openFileDialog1.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txtDistinguishMarks.Text = openFileDialog1.FileName;
                pbMarks.ImageLocation = openFileDialog1.FileName;
                pbMarks.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void TxtCourt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPoliceStation = cboStation.SelectedItem.ToString();

            // Update comboBox2 with the corresponding barangays
            UpdateBrgyComboBox(selectedPoliceStation);
        }

        private void UpdateBrgyComboBox(string policeStation)
        {
            // Clear the existing items in comboBox2
            cboPlace.Items.Clear();

            // Add the barangays based on the selected police station
            switch (policeStation)
            {
                case "Police Station 1 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Dadiangas East");
                    cboPlace.Items.Add("Dadiangas North");
                    cboPlace.Items.Add("Dadiangas South");
                    cboPlace.Items.Add("Dadiangas West");
                    break;

                case "Police Station 2 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Labangal");
                    cboPlace.Items.Add("City Heights");
                    cboPlace.Items.Add("Apopong");
                    cboPlace.Items.Add("Sinawal");
                    break;

                case "Police Station 3 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Buayan");
                    cboPlace.Items.Add("Lagao");
                    cboPlace.Items.Add("Ligaya");
                    cboPlace.Items.Add("Upper Labay");
                    break;

                case "Police Station 4 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("San Isidro");
                    cboPlace.Items.Add("Mabuhay");
                    cboPlace.Items.Add("Conel");
                    cboPlace.Items.Add("Katangawan");
                    break;

                case "Police Station 5 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Bawing/Siguel");
                    cboPlace.Items.Add("Tambler");
                    break;

                case "Police Station 6 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Baluan");
                    cboPlace.Items.Add("Bula");
                    break;

                case "Police Station 7 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Calumpang");
                    cboPlace.Items.Add("Fatima");
                    cboPlace.Items.Add("San Jose");
                    break;

                case "Police Station 8 (GENERAL SANTOS CITY)":
                    cboPlace.Items.Add("Tinagacan");
                    cboPlace.Items.Add("Batomelong");
                    cboPlace.Items.Add("Olympog");
                    break;

                default:
                    break;
            }
        }

        private void BunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void BunifuBtnBook_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" ||
            txtLastname.Text == "" ||
            txtFirstname.Text == "" ||
            txtMiddlename.Text == "" ||
            cboOffense.Text == "" ||
            txtCourt.Text == "" ||
            txtResidenceadd.Text == "" ||
            txtProvincialadd.Text == "" ||
            txtAge.Text == "" ||
            cboSex.Text == "" ||
            txtComplexion.Text == "" ||
            txtNationality.Text == "" ||
            txtCitizenship.Text == "" ||
            cboReligion.Text == "" ||
            txtoccupation.Text == "" ||
            txtHeight.Text == "" ||
            txtWeight.Text == "" ||
            txtHaircolor.Text == "" ||
            cboEyecolor.Text == "" ||
            cboBloodtype.Text == "" ||
            dtpBirth.Text == "" ||
            txtPlaceofBirth.Text == "" ||
            txtEducation.Text == "" ||
            cboStatus.Text == "" ||
            //txtNameofWife.Text == "" ||
            //txtNumberofChildren.Text == "" ||
            txtFathersname.Text == "" ||
            txtMothersname.Text == "" ||
            txtAddress.Text == "" ||
            txtContactperson.Text == "" ||
            cboRelationship.Text == "" ||
            txtContactnum.Text == "" ||
            txtCaddress.Text == "" ||
            cboPlace.Text == "" ||
            txtPlace2.Text == "" ||
            dtpArrested.Text == "" ||
            txtCircumstances.Text == "" ||
            dtpCommited.Text == "" ||
            cboArresting.Text == "" ||
            //cboStation.Text == "" ||
            dtpConfinement.Text == "" ||
            cboReceivingOfficer.Text == "" ||
            cboSearchBy.Text == "" ||
            txtProperty.Text == "" ||
            txtKind.Text == "" ||
            txtMarks.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_bookings(bookingid,firstname,middlename,lastname,offense,court,residenceadd,provincialadd," +
                    "age,sex,complexion,nationality,citizenship,religion,occupation,height,weight,haircolor,eyecolor,bloodtype," +
                    "birth,placeofbirth,education,maritalstatus,wifename,childnumber,fathername,mothername,address,confirmation) VALUES (" +
                    "'" + txtID.Text + "','" + txtFirstname.Text + "','" + txtMiddlename.Text + "','" + txtLastname.Text +
                "','" + cboOffense.Text + "', '" + txtCourt.Text + "', '" + txtResidenceadd.Text + "', '" + txtProvincialadd.Text +
                "','" + txtAge.Text + "','" + cboSex.Text + "','" + txtComplexion.Text + "','" + txtNationality.Text + 
                "','" + txtCitizenship.Text + "','" + cboReligion.Text + "','" + txtoccupation.Text + "','" + txtHeight.Text +
                "','" + txtWeight.Text + "', '" + txtHaircolor.Text + "','" + cboEyecolor.Text +
                "','" + cboBloodtype.Text + "','" + dtpBirth.Text + "','" + txtPlaceofBirth.Text + "','" + txtEducation.Text + 
                "', '" + cboStatus.Text + "','" + txtNameofWife.Text + "','" + txtNumberofChildren.Text + "','" + txtFathersname.Text + 
                "','" + txtMothersname.Text + "','" + txtAddress.Text + "', 'Forwarded')";
                config.Execute_Query(sql);

                sql2 = "INSERT INTO tbl_pdlinfo(pdlId,contactperson,relationship,contactnum,caddress,place,place2,arrested,circumstances," +
                    "committed,arresting,station,confinement,receivingofficer,searchby,property,kind,marks,mugshot,signature,distinguishmarks) VALUES (" +
                    "'" + txtID.Text + "','" + txtContactperson.Text + "','" + cboRelationship.Text + "','" + txtContactnum.Text +
                "','" + txtCaddress.Text + "', '" + cboPlace.Text + "', '" + txtPlace2.Text + "', '" + dtpArrested.Text + 
                "','" + txtCircumstances.Text + "', '" + dtpCommited.Text + "', '" + cboArresting.Text + "', '" + cboStation.Text + 
                "','" + dtpConfinement.Text + "', '" + cboReceivingOfficer.Text + "', '" + cboSearchBy.Text + "','" + txtProperty.Text +
                "','" + txtKind.Text + "', '" + txtMarks.Text + "','" + Path.GetFileName(pbMugshot.ImageLocation) + 
                "','" + Path.GetFileName(pbSignature.ImageLocation) + "','" + Path.GetFileName(pbMarks.ImageLocation) + "')";
                config.Execute_CUD(sql2, "No data save.", "Data has been saved in the database");

                if (txtMugshot.Text != "")
                {
                    File.Copy(txtMugshot.Text, Application.StartupPath + "//InmatePhoto//" + Path.GetFileName(pbMugshot.ImageLocation), true);
                }
                if (txtSignature.Text != "")
                {
                    File.Copy(txtSignature.Text, Application.StartupPath + "//InmatePhoto//" + Path.GetFileName(pbSignature.ImageLocation), true);
                }
                if (txtDistinguishMarks.Text != "")
                {
                    File.Copy(txtDistinguishMarks.Text, Application.StartupPath + "//InmatePhoto//" + Path.GetFileName(pbMarks.ImageLocation), true);
                }

                this.Hide();
            }
        }
    }
}
