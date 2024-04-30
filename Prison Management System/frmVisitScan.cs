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
    public partial class frmVisitScan : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;
        public frmVisitScan()
        {
            InitializeComponent();
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tbl_booking WHERE id = '" + txtID.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");
                string query = "SELECT * FROM tbl_visitlist where ID Like'%" + txtID.Text + "%'";
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(query, con);
                MySqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    bTxtfname.Text = rd2["fullname"].ToString();
                    bTxtcontact.Text = rd2["contact"].ToString();
                    bTxtRelation.Text = rd2["relation"].ToString();
                }
                pictureBox1.ImageLocation = Application.StartupPath + "//InmatePhoto//" + config.dt.Rows[0].Field<string>("photo").ToString();
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;Password=;database=prison_db;");
                string query = "SELECT * FROM tbl_visitlist where ID Like'%" + txtID.Text + "%'";
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(query, con);
                MySqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    bTxtfname.Text = rd2["fullname"].ToString();
                    bTxtcontact.Text = rd2["contact"].ToString();
                    bTxtRelation.Text = rd2["relation"].ToString();
                }
                pictureBox1.ImageLocation = Application.StartupPath + "//InmatePhoto//no_image.png";
            }
        }

        private void FrmVisitScan_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtID_TextChanged(this, new EventArgs());
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            bTxtfname.Text = "";
            bTxtcontact.Text = "";
            bTxtRelation.Text = "";
            txtID.Text = "";
        }
    }
}
