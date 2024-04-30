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
    public partial class dashboardpanel : Form
    {
        public dashboardpanel()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        public string type;

        public void count()
        {
            double totalInmate = Convert.ToDouble(config.totalInmate());
            inmatecounts.Text = totalInmate.ToString();
            double totalPrison = Convert.ToDouble(config.totalPrison());
            prisoncount.Text = totalPrison.ToString();
            double totalCellblock = Convert.ToDouble(config.totalCellBlock());
            cellcounts.Text = totalCellblock.ToString();
            //double totalRelease = Convert.ToDouble(config.totalRelease());
            //releasecounts.Text = totalRelease.ToString();
            double totalCrimes = Convert.ToDouble(config.totalCrimes());
            crimecounts.Text = totalCrimes.ToString();
            //double totalVisit = Convert.ToDouble(config.totalTodayVisit());
            //visitcounts.Text = totalVisit.ToString();
            double totalAction = Convert.ToDouble(config.totalAction());
            actioncounts.Text = totalAction.ToString();
        }

        private void Dashboardpanel_Load(object sender, EventArgs e)
        {
            count();
        }

        private void prisoncount_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            frm.loadform(new inmatelistpanel());
        }
    }
}
