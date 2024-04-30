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
    public partial class confirmBooking : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public static confirmBooking frm;
        public static confirmBooking getData
        {
            get
            {
                if (frm == null)
                {
                    frm = new confirmBooking();
                }
                return frm;
            }
        }

        public confirmBooking()
        {
            InitializeComponent();
        }

        private void ConfirmBooking_Load(object sender, EventArgs e)
        {
            txtId.Text = bookingconfirmationpanel.selectedrow.Cells[0].Value.ToString();
            txtFname.Text = bookingconfirmationpanel.selectedrow.Cells[1].Value.ToString();
            cboSex.Text = bookingconfirmationpanel.selectedrow.Cells[2].Value.ToString();
            dtpBirth.Text = bookingconfirmationpanel.selectedrow.Cells[3].Value.ToString();
            txtAddress.Text = bookingconfirmationpanel.selectedrow.Cells[4].Value.ToString();
            cboMarital.Text = bookingconfirmationpanel.selectedrow.Cells[5].Value.ToString();
            txtComplexion.Text = bookingconfirmationpanel.selectedrow.Cells[6].Value.ToString();
            txtEyecolor.Text = bookingconfirmationpanel.selectedrow.Cells[7].Value.ToString();
            txtMugshot.Text = bookingconfirmationpanel.selectedrow.Cells[8].Value.ToString();

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

            txtId.Enabled = false;
            txtFname.Enabled = false;
            cboSex.Enabled = false;
            dtpBirth.Enabled = false;
            txtAddress.Enabled = false;
            cboMarital.Enabled = false;
            txtComplexion.Enabled = false;
            txtEyecolor.Enabled = false;
            txtMugshot.Enabled = false;
        }

        private void BunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            sql = "UPDATE tbl_bookings SET confirmation = 'Detained' WHERE bookingid = '" + txtId.Text + "'";
            config.Execute_CUD(sql, "No data updated.", "Data has been updated in the database");
            this.Hide();
        }
    }
}
