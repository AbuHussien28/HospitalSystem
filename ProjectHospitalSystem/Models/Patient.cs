using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        [MaxLength(7)]
        public string Gender { get; set; }
        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(70)]
        public string Address { get; set; }
        [MaxLength(300)]
        public string MedicalHistory { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Appointment> Appointment { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorDetailsId { get; set; }
        public virtual DoctorDetails DoctorDetails { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
