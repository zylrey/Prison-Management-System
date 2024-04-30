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
using QRCoder;
using System.IO;

namespace Prison_Management_System
{
    public partial class addvisitorpanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public addvisitorpanel()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void clear()
        {
            txtFullname.Clear();
            txtContact.Clear();
            txtRelation.Clear();
            cboOIC.Text = "";
            cbInmate.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" ||
            txtContact.Text == "" ||
            txtRelation.Text == "" ||
            cboOIC.Text == "" ||
            cbInmate.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_visitlist(fullname,contact,relation,oic,inmate) VALUES ('" + txtFullname.Text + "','" + txtContact.Text + "', '" + txtRelation.Text +
                "','" + cboOIC.Text + "','" + cbInmate.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                clear();
                this.Hide();
            }
        }

        private void CbInmate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addvisitorpanel_Load(object sender, EventArgs e)
        {
            int maxnum = int.Parse("999999");
            Random rnd = new Random();
            int randomnum = rnd.Next(0, maxnum);

            txtId.Text = randomnum.ToString();

            txtQRCode.Text = randomnum.ToString();

            cboOIC.Text = globals.first_name;
            cboOIC.Enabled = false;

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery = "SELECT * FROM tbl_booking WHERE confirmation = 'Detained'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cbInmate.Items.Add(rd.GetString("fullname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");

                string selectQuery2 = "SELECT * FROM tbl_user";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery2, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboOIC.Items.Add(rd.GetString("firstname"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CboOIC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtFullname.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pbQRCode.Image = code.GetGraphic(5);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtId.Text + " " + txtFullname.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pbQRCode.Image = code.GetGraphic(5);
        }

        private void BunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (txtFullname.Text == "" ||
            txtContact.Text == "" ||
            txtRelation.Text == "" ||
            cboOIC.Text == "" ||
            cbInmate.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbQRCode.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);
                
                sql = "INSERT INTO tbl_visitlist(id,fullname,contact,relation,oic,inmate,qrcode) VALUES ('" + txtId.Text + "','" + txtFullname.Text + "','" + txtContact.Text + "', '" + txtRelation.Text +
                "','" + cboOIC.Text + "','" + cbInmate.Text + "', '" + txtId.Text + "')";
                config.savephoto_name(sql,pbQRCode);
                clear();
                this.Hide();
            }
            string initialDIR = @"C:\Users\acer\Desktop\QRfiles";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbQRCode.Image.Save(dialog.FileName);
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
