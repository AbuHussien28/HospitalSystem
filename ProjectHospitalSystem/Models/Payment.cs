using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal AmountPaid { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dddd yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; } 
        [ForeignKey("Bill")]
        public int? BillId { get; set; }
        [ForeignKey("PaymentMethod")]
        public int? PaymentMethodId { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
