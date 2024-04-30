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
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Prison_Management_System
{
    public partial class confirmationpanel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        public string userid { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string ext { get; set; }
        public string ni { get; set; }
        public string address { get; set; }
        public string doc { get; set; }
        public string ao { get; set; }
        public string co { get; set; }
        public string ncj { get; set; }
        public string acj { get; set; }
        public string bo { get; set; }

        public confirmationpanel()
        {
            InitializeComponent();
        }

        private void confirmationpanel_Load(object sender, EventArgs e)
        {
            txtId.Text = userid;
            txtFname.Text = fname;
            txtMname.Text = mname;
            txtLname.Text = lname;
            txtExt.Text = ext;
            txtNI.Text = ni;
            txtAddress.Text = address;
            txtDOC.Text = doc;
            txtAO.Text = ao;
            txtCO.Text = co;
            //txtNCJ.Text = ncj;
            //txtACJ.Text = acj;
            //txtBO.Text = bo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" ||
            txtFname.Text == "" ||
            txtMname.Text == "" ||
            txtLname.Text == "" ||
            txtNI.Text == "" ||
            txtAddress.Text == "" ||
            txtDOC.Text == "" ||
            txtAO.Text == "" ||
            txtCO.Text == "" )
            //txtNCJ.Text == "" ||
            //txtACJ.Text == "" ||
            //txtBO.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_booking(id,fullname,ext,ni,address,doc,ao,co) VALUES ('" + txtId.Text + "','" + txtFname.Text + " " + txtMname.Text + " " + txtLname.Text + 
                "','" + txtExt.Text + "', '" + txtNI.Text + "','" + txtAddress.Text + "', '" + txtDOC.Text + "','" + txtAO.Text +
                "','" + txtCO.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
