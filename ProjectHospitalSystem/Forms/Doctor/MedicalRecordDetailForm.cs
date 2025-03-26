using Microsoft.EntityFrameworkCore;
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

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class MedicalRecordDetailForm : Form
    {
        private  HospitalSystemContext _context;
        private  int _medicalId;
        private MedicalRecord _record;
        public MedicalRecordDetailForm(int medicalId)
        {
            InitializeComponent();
            _context = new HospitalSystemContext();
            _medicalId = medicalId;
            LoadRecordData();
        }
        private void LoadRecordData()
        {
            try
            {
                _record = _context.MedicalRecords
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Patient)
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Doctor)
                            .ThenInclude(d => d.User)
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Doctor)
                            .ThenInclude(d => d.Dept)
                    .FirstOrDefault(m => m.MedicalId == _medicalId);

                if (_record == null)
                {
                    MessageBox.Show("Medical record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                patientName.Text = $"{_record.Appointments.Patient.FirstName} {_record.Appointments.Patient.LastName}";
                patientAge.Text = (DateTime.Now.Year - _record.Appointments.Patient.DateOfBirth.Year).ToString();
                patientDateVisit.Text = _record.DateOfVist.ToString("yyyy-MM-dd HH:mm");
                doctorName.Text = $"{_record.Appointments.Doctor.User.FName} {_record.Appointments.Doctor.User.LName}";
                deptName.Text = _record.Appointments.Doctor.Dept.DeptName;

                txt_Diaqnois.Text = _record.Diaqnois;
                txt_labresult.Text = _record.LabResult;
                txt_prescription.Text = _record.Prescription;
                txt_treatmentDeatis.Text = _record.TreatmentDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
