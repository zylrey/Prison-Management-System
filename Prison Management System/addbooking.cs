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
using System.IO;

namespace Prison_Management_System
{
    public partial class addbooking : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public addbooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" ||
            txtFname.Text == "" ||
            txtMname.Text == "" ||
            txtLname.Text == "" ||
            cboNI.Text == "" ||
            cboACI.Text == "" ||
            txtACI.Text == "" ||
            dtpDOC.Text == "" ||
            cboAO.Text == "" ||
            cboCO.Text == "")
            //txtNCJ.Text == "" ||
            //txtACJ.Text == "" ||
            //txtBO.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_booking(id,fullname,ext,ni,address,doc,ao,co) VALUES ('" + txtId.Text + "','" + txtFname.Text + " " + txtMname.Text + " " + txtLname.Text +
                "','" + txtExt.Text + "', '" + cboNI.Text + "','" + txtACI.Text + ", " + cboACI.Text + "', '" + dtpDOC.Text + "','" + cboAO.Text +
                "','" + cboCO.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                this.Hide();
            }

            /**
            confirmationpanel frm = new confirmationpanel();
            frm.userid = txtId.Text;
            frm.fname = txtFname.Text;
            frm.mname = txtMname.Text;
            frm.lname = txtLname.Text;
            frm.ext = txtExt.Text;
            frm.ni = cboNI.Text;
            frm.address = txtAddress.Text + ", " + comboBox1.Text;
            frm.doc = txtDOC.Text;
            frm.ao = cboAO.Text;
            frm.co = cboCO.Text;
            //frm.ncj = txtNCJ.Text;
            //frm.acj = txtACJ.Text;
            //frm.bo = txtBO.Text;
            frm.ShowDialog();

            //new addFingerprint().Show(); */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addbooking_Load(object sender, EventArgs e)
        {
            int maxnum = int.Parse("10000");
            Random rnd = new Random();
            int randomnum = rnd.Next(0, maxnum);

            txtId.Text = randomnum.ToString();

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT firstname FROM tbl_officer";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboAO.Items.Add("Police Officer " + rd.GetString("firstname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT firstname FROM tbl_officer";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboCO.Items.Add("Police Officer " + rd.GetString("firstname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text == "" ||
            txtFname.Text == "" ||
            txtMname.Text == "" ||
            txtLname.Text == "" ||
            cboSex.Text == "" ||
            dtpBirth.Text == "" ||
            txtAddress.Text == "" ||
            cboMarital.Text == "" ||
            txtComplexion.Text == "" ||
            txtEyecolor.Text == "" ||
            cboNI.Text == "" ||
            cboACI.Text == "" ||
            txtACI.Text == "" ||
            dtpDOC.Text == "" ||
            cboAO.Text == "" ||
            cboCO.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_booking(id,fullname,ext,sex,birth,address,marital,complexion,eyecolor,ni,ACI,doc,ao,co,mugshot,fname,mname,lname,extension,confirmation) VALUES ('" + txtId.Text + "','" + txtFname.Text + " " + txtMname.Text + " " + txtLname.Text +
                "','" + txtExt.Text + "', '" + cboSex.Text + "', '" + dtpBirth.Text + "', '" + txtAddress.Text + "', '" + cboMarital.Text + "', '" + txtComplexion.Text + "', '" + txtEyecolor.Text + "', '" + cboNI.Text + "','" +
                txtACI.Text + ", " + cboACI.Text + "', '" + dtpDOC.Text + "','" + cboAO.Text +
                "','" + cboCO.Text + "', '" + Path.GetFileName(pbMugshot.ImageLocation) + "','" + txtFname.Text + "','" + txtMname.Text + "','" + txtLname.Text + "','" + txtExt.Text + "', 'Forwarded')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                this.Hide();

                if (txtMugshot.Text != "")
                {
                    File.Copy(txtMugshot.Text, Application.StartupPath + "//InmatePhoto//" + Path.GetFileName(pbMugshot.ImageLocation), true);
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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

        private void CboAO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
