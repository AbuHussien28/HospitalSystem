using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Upcoming;
        [Required, MaxLength(150)]
        public string Note { get; set; }
        public bool ReminderSent { get; set; } = false;
        [ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        [ForeignKey("MedicalRecord")]
        public int? medicalRecordId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorDetailsId { get; set; }
        public virtual DoctorDetails Doctor { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual MedicalRecord MedicalRecord { get; set; }

    }
}
