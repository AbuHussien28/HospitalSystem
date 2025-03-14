﻿using DevExpress.XtraScheduler;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    public class DoctorDetails
    {
        [Key]
        public int DoctorDetailsId { get; set; }
        [Required, MaxLength(70)]
        public string Specialization { get; set; }
        public int? DeptId { get; set; }
        [ForeignKey("DeptId")]
        public virtual Department Dept { get; set; }
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
        public virtual List<Doctor_Schedule> doctorSchedule { get; set; }
    }
}
