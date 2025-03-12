using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraScheduler;

namespace ProjectHospitalSystem.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal OriginalAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? LateFee { get; set; }
        [NotMapped]
        public decimal TotalAmount => OriginalAmount + (LateFee ?? 0);
        public DateTime GenertedDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }
        public BillStatus Status { get; set; } = BillStatus.unPaid;
        public int PatientId { get; set; }
        public int DepartmentId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("Appointment")]
        public int? AppointmentId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual Appointment Appointment { get; set; }
        public virtual User User { get; set; } 
    }
}
