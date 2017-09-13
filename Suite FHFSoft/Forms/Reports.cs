using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suite_FHFSoft
{
    public partial class Reports : Form
    {
        ReportDocument report = new ReportDocument();

        DataTable dtReport = new DataTable();
        public string vReportName = "";
        public string vSQLString = "";

        string vTitleReports = "";
        public Reports()
        {
            InitializeComponent();
        }

        private void radTitleBar1_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {

            dtReport = C.SQL(vSQLString);



            report.Load("C:\\Users\\LHVCDevelopment1\\Documents\\Visual Studio 2015\\Projects\\Evolution\\Evolution\\Reports\\" + vReportName);
            report.SetDatabaseLogon("", "");
            report.SetDataSource(dtReport);

            crystalReportViewer1.ReportSource = report;
            //crystalReportViewer1.ReportSource= "C:\\Users\\LHVCDevelopment1\\Documents\\Visual Studio 2015\\Projects\\Evolution\\Evolution\\Reports\\" + vReportName;

            crystalReportViewer1.Refresh();
        }

        private void SetTitle()
        {
            this.Text = vTitleReports;
        }
    }
}
