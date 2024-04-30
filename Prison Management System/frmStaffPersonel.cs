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
    public partial class frmStaffPersonel : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public string type;
        string sql;
        public frmStaffPersonel()
        {
            InitializeComponent();
        }

        private void FrmStaffPersonel_Load(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(firstname, ' ', middlename, ' ', lastname) as 'Staff/Personnel Fullname',currentdepartment as 'Department',historydepartment as 'Assignment Department History' FROM tbl_user";
            config.Load_DTG(sql, bunifuCustomDataGrid1);
            funct.ResponsiveDtg(bunifuCustomDataGrid1);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            new addStaffPersonnel().Show();
        }
    }
}
