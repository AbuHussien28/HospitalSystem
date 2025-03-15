using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem.Forms.Doctor
{

    public partial class Edit_Medical_Record : Form
    {
        HospitalSystemContext db;
        private int medicalRecordId;
        private int? patientId;
        private int? appintmentId;
        public Edit_Medical_Record(int medicalRecordId, int? patientId, int? appintmentId)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            this.medicalRecordId = medicalRecordId;
            this.patientId = patientId;
            this.appintmentId = appintmentId;

            patientName.Text = db?.Patients.Where(n => n.PatientId == patientId).Select(n => n.FullName).FirstOrDefault();
            try
            {
                var record = db?.MedicalRecords.Find(medicalRecordId);
                if (record != null)
                {
                    txt_Diaqnois.Text = record.Diaqnois;
                    txt_labresult.Text = record.LabResult;
                    txt_prescription.Text = record.Prescription;
                    txt_treatmentDeatis.Text = record.TreatmentDetails;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            var patientName = db.Patients.Where(n => n.PatientId == patientId).Select(n => n.FullName).FirstOrDefault();
            try
            {
                var record = db.MedicalRecords.Find(medicalRecordId);
                if (record != null)
                {
                    record.Diaqnois = txt_Diaqnois.Text;
                    record.LabResult = txt_labresult.Text;
                    record.Prescription = txt_prescription.Text;
                    record.TreatmentDetails = txt_treatmentDeatis.Text;
                }
                MessageBox.Show($"Medical Record For Patient {patientName} Is Update");
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Update medical record: {ex.Message}");

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var patientName = db.Patients.Where(n => n.PatientId == patientId).Select(n => n.FullName).FirstOrDefault();

            try
            {
                var record = db.MedicalRecords.Find(medicalRecordId);
                if (record != null)
                {
                    if (MessageBox.Show($"Do You Need Medical Record For Patient {patientName}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var appointmentsWithRecord = db.Appointments.Where(a => a.medicalRecordId == medicalRecordId).ToList();
                        foreach (var appointment in appointmentsWithRecord)
                        {
                            appointment.medicalRecordId = null;
                        }

                        db.MedicalRecords.Remove(record);
                        db.SaveChanges();

                    }
                }
                else
                {
                    MessageBox.Show("No data found for deletion.");
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }
        }
    }
}
