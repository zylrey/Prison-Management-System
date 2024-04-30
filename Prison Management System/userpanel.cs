using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Management_System
{
    public partial class userpanel : Form
    {
        public userpanel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new adduserpanel().Show();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;

        private void Userpanel_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            sql = "SELECT concat(lastname,', ',firstname,' ',  middlename) as 'Full User Name' " +
            ", username as 'Username', type as 'Type' FROM tbl_user";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this User Details permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_user WHERE user_id='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'";
                config.Load_DTG(sql, bunifuCustomDataGrid1);
                MessageBox.Show("User has been Remove!");

                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                refresh();
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void retrieve_data()
        {

        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            new addUser().Show();
        }
    }
}
