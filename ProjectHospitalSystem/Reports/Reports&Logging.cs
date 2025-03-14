using ProjectHospitalSystem.Forms.Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHospitalSystem.Reports;
using DevExpress.XtraReports.UI;
using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem.Reports
{
    public partial class Reports_Logging : Form
    {
        private readonly HospitalSystemContext _context = new HospitalSystemContext();
        public Reports_Logging()
        {
            InitializeComponent();
        }

        private void btn_RepNumberPatient_Click(object sender, EventArgs e)
        {
            Report1 report = new Report1(); 
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btn_RepSechedule_Click(object sender, EventArgs e)
        {

            Report2 report = new Report2();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }

        private void btn_RepOutstandPay_Click(object sender, EventArgs e)
        {

            Report3 report = new Report3();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }

        private void btn_RepVistHist_Click(object sender, EventArgs e)
        {

            Report4 report = new Report4();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
