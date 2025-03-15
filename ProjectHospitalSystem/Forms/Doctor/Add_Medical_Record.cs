using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class Add_Medical_Record : Form
    {
        private int appointmentId;
        private int? patientId;
        HospitalSystemContext db;
        public Add_Medical_Record(int appointmentId, int? patientId)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            this.appointmentId = appointmentId;
            this.patientId = patientId;

            patientName.Text = db.Patients.Where(n => n.PatientId == patientId).Select(n => n.FullName).FirstOrDefault();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                MedicalRecord record = new MedicalRecord()
                {
                    DateOfVist = DateTime.Now,
                    Diaqnois = txt_Diaqnois.Text,
                    Prescription = txt_prescription.Text,
                    LabResult = txt_labresult.Text,
                    TreatmentDetails = txt_treatmentDeatis.Text
                };

                db.MedicalRecords.Add(record);
                db.SaveChanges();

                var appointment = db.Appointments.Find(appointmentId);
                if (appointment != null)
                {
                    appointment.medicalRecordId = record.MedicalId;
                    db.SaveChanges();
                }
                MessageBox.Show("Medical record created successfully!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving medical record: {ex.Message}");
            }
        }
    }
}
