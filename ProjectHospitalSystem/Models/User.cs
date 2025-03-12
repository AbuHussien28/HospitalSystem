using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Required, MaxLength(50)]
        public string FName { get; set; }
        [Required, MaxLength(50)]
        public string LName { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [MaxLength(30)]
        public string Role { get; set; }
        [ForeignKey("doctorDetails")]
        public int? DoctorDetailsId { get; set; }
        public virtual DoctorDetails doctorDetails { get; set; }
        public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
        public virtual ICollection<User_Phone> UserPhones { get; set; }=new List<User_Phone>();
    }
}
