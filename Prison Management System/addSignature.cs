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
    public partial class addSignature : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        public addSignature()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new confirmationpanel().Show();
            this.Hide();
            /**
            addbooking frm1 = new addbooking();

            if (frm1.txtFname.Text == "" ||
            frm1.txtMname.Text == "" ||
            frm1.txtLname.Text == "" ||
            frm1.txtExt.Text == "" ||
            frm1.txtNI.Text == "" ||
            frm1.txtAddress.Text == "" ||
            frm1.txtDOC.Text == "" ||
            frm1.txtAO.Text == "" ||
            frm1.txtCO.Text == "" ||
            frm1.txtNCJ.Text == "" ||
            frm1.txtACJ.Text == "" ||
            frm1.txtBO.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO tbl_booking(firstname,middlename,lastname,ext,ni,address,doc,ao,co,ncj,acj,bo) VALUES ('" + frm1.txtFname.Text + "', '" + frm1.txtMname.Text +
                "','" + frm1.txtLname.Text + "','" + frm1.txtExt.Text + "', '" + frm1.txtNI.Text + "','" + frm1.txtAddress.Text + "', '" + frm1.txtDOC.Text + "','" + frm1.txtAO.Text + 
                "','" + frm1.txtCO.Text + "','" + frm1.txtNCJ.Text + "', '" + frm1.txtACJ.Text + "','" + frm1.txtBO.Text + "')";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");
                this.Hide();
            } */
        }
    }
}
