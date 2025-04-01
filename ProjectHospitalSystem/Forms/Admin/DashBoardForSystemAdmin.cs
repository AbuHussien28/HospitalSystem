using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class DashBoardForSystemAdmin : Form
    {
        private HospitalSystemContext _context;
        public DashBoardForSystemAdmin()
        {
            _context = new HospitalSystemContext();
            InitializeComponent();
        }

        private void DashBoardForSystemAdmin_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void CreateKPICard(Panel panel, string title, string value, Image icon)
        {
            panel.Controls.Clear();

            var layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.RowCount = 2;
            layout.ColumnCount = 1;
            var titleLabel = new LabelControl();
            titleLabel.Text = title;
            titleLabel.Appearance.Font = new Font("Tahoma", 14, FontStyle.Bold);
            titleLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            titleLabel.Dock = DockStyle.Fill;

            // Value Label
            var valueLabel = new LabelControl();
            valueLabel.Text = value;
            valueLabel.Appearance.Font = new Font("Tahoma", 20, FontStyle.Bold);
            valueLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            valueLabel.Dock = DockStyle.Fill;

            // Icon
            var pictureBox = new PictureBox();
            if (icon != null)
            {
                pictureBox.Image = icon;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Left;
                pictureBox.Width = 40;
            }

            layout.Controls.Add(titleLabel, 0, 0);
            layout.Controls.Add(valueLabel, 0, 1);

            var container = new Panel();
            container.Dock = DockStyle.Fill;
            container.Controls.Add(pictureBox);
            container.Controls.Add(layout);

            panel.Controls.Add(container);
        }
        private void CreateKPICards()
        {
            try
            {
                var totalPatients = _context.Patients.Count();
                CreateKPICard(panelKpi1, "Total Patients", totalPatients.ToString(),
                    Properties.Resources.IconPaientent128px); 
                var totalDoctors = _context.Doctors.Count();
                CreateKPICard(panelKpi2, "Total Doctors make Medical Record", totalDoctors.ToString(),
                    Properties.Resources.IconDoctor128px );
                var todayAppointments = _context.Appointments
                    .Count(a => a.AppointmentDateTime.Date == DateTime.Today);
                CreateKPICard(panelKpi3, "Today's Appointments", todayAppointments.ToString(),
                    Properties.Resources.IconDoctorAppoiment);
                var monthlyRevenue = _context.payments
                    .Where(p => p.PaymentDate.Month == DateTime.Today.Month &&
                               p.PaymentDate.Year == DateTime.Today.Year)
                    .Sum(p => p.AmountPaid);
                CreateKPICard(panelKpi4, "Monthly Revenue", monthlyRevenue.ToString()+" EGP",
                    Properties.Resources.IconRevenue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading KPI data: {ex.Message}");
            }
        }
        private void CreatePatientDemographicsChart()
        {
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;
            panelPatientDemographics.Controls.Add(chart);
            var genderData = _context.Patients
                .GroupBy(p => p.Gender)
                .Select(g => new { Gender = g.Key, Count = g.Count() })
                .ToList();
            Series series = new Series("Patients by Gender", ViewType.Pie);

            foreach (var item in genderData)
            {
                series.Points.Add(new SeriesPoint(item.Gender, item.Count));
            }
            PieSeriesView view = (PieSeriesView)series.View;
            view.ExplodedPoints.Add(series.Points[0]);
            view.ExplodeMode = PieExplodeMode.UsePoints;
            view.RuntimeExploding = true;
            view.Rotation = 45;
            PieSeriesLabel label = (PieSeriesLabel)series.Label;
            label.TextPattern = "{A}: {V}";
            label.Position = PieSeriesLabelPosition.TwoColumns;
            label.ResolveOverlappingMode = ResolveOverlappingMode.Default;
            label.Font = new Font("Tahoma", 9, FontStyle.Bold);
            label.Shadow.Visible = false;
            label.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chart.Series.Add(series);
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart.Titles.Add(new ChartTitle
            {
                Text = "Patient Demographics by Gender",
                Font = new Font("Tahoma", 12, FontStyle.Bold)
            });
        }
        private void CreateAppointmentsChart()
        {
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;
            panelAppointments.Controls.Add(chart);
            var startDate = DateTime.Today.AddDays(-30);
            var appointmentData = _context.Appointments
                .Where(a => a.AppointmentDateTime >= startDate)
                .GroupBy(a => a.AppointmentDateTime.Date)
                .OrderBy(g => g.Key)
                .Select(g => new { Date = g.Key, Count = g.Count() })
                .ToList();
            Series series = new Series("Daily Appointments", ViewType.Line);

            foreach (var item in appointmentData)
            {
                series.Points.Add(new SeriesPoint(item.Date.ToShortDateString(), item.Count));
            }
    ((LineSeriesView)series.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series.View).LineMarkerOptions.Kind = MarkerKind.Circle;
            ((LineSeriesView)series.View).LineStyle.DashStyle = DashStyle.Solid;
            chart.Series.Add(series);
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart.Titles.Add(new ChartTitle { Text = "Appointments Trend (Last 30 Days)" });
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
            diagram.AxisX.Label.Angle = -30;
        }
        private void CreateDepartmentStatisticsChart()
        {
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;
            panelDepartmentStats.Controls.Add(chart);
            var deptData = _context.Departments
                .Select(d => new
                {
                    Department = d.DeptName,
                    Doctors = d.Doctors.Count,
                    Appointments = d.Doctors.Sum(doc => doc.Appointments.Count)
                })
                .ToList();
            Series doctorsSeries = new Series("Doctors per Department", ViewType.Bar);
            foreach (var item in deptData)
            {
                doctorsSeries.Points.Add(new SeriesPoint(item.Department, item.Doctors));
            }
            Series appointmentsSeries = new Series("Appointments per Department", ViewType.Bar);
            foreach (var item in deptData)
            {
                appointmentsSeries.Points.Add(new SeriesPoint(item.Department, item.Appointments));
            }

            chart.Series.AddRange(new Series[] { doctorsSeries, appointmentsSeries });

            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart.Titles.Add(new ChartTitle { Text = "Department Statistics" });
            ((XYDiagram)chart.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
            ((XYDiagram)chart.Diagram).AxisX.Label.Angle = -30;
        }
        private void CreateDoctorWorkloadChart()
        {
            ChartControl chart = new ChartControl();
            chart.Dock = DockStyle.Fill;
            panelDoctorWorkload.Controls.Add(chart);
            var doctorData = _context.Doctors
                .OrderByDescending(d => d.Appointments.Count)
                .Take(5)
                .Select(d => new
                {
                    DoctorName = d.User.FName + " " + d.User.LName,
                    Appointments = d.Appointments.Count,
                    Specialization = d.Specialization
                })
                .ToList();
            Series series = new Series("Doctor Workload", ViewType.Bar);

            foreach (var item in doctorData)
            {
                series.Points.Add(new SeriesPoint(item.DoctorName, item.Appointments));
            }

    ((BarSeriesView)series.View).ColorEach = true;

            chart.Series.Add(series);

            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chart.Titles.Add(new ChartTitle { Text = "Number of Appointments" });
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            diagram.AxisX.Label.Angle = -30;
            diagram.AxisY.Title.Text = "Top 5 Doctors";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }
        public void Reload()
        {
            try
            {
                panelPatientDemographics.Controls.Clear();
                panelAppointments.Controls.Clear();
                panelDepartmentStats.Controls.Clear();
                panelDoctorWorkload.Controls.Clear();
                CreateKPICards();
                CreatePatientDemographicsChart();
                CreateAppointmentsChart();
                CreateDepartmentStatisticsChart();
                CreateDoctorWorkloadChart();
                lblStatus.Text = "Last updated: " + DateTime.Now.ToString("hh:mm:ss tt");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error reloading dashboard: {ex.Message}", "Error");
            }
        }
         

    }
}
