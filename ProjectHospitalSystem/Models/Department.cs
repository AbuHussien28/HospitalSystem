﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required, MaxLength(50)]
        public string DeptName { get; set; }
        [MaxLength(70)]
        public string? Dept_Desc { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal FeeAmount { get; set; }
        public int? DoctorMgnId { get; set; }
        [ForeignKey("DoctorMgnId")]
        public virtual DoctorDetails DoctorManger { get; set; }
        public virtual List<DoctorDetails> Doctors { get; set; }
    }
}
