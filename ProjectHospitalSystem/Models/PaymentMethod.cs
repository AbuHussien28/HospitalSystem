using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class PaymentMethod
    {
        [Key]
        public int paymentMethodId { get; set; }
        [Required, MaxLength(70)]
        public string paymentMethodName { get; set; }
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
