using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models
{
    [PrimaryKey(nameof(DoctorDetailsId), nameof(ScheduleDay))]
    public class Doctor_Schedule
    {
        public DateTime ScheduleDay { get; set; }
        [ForeignKey("Doctor")]
        public int? DoctorDetailsId { get; set; }
        public virtual DoctorDetails Doctor { get; set; }
    }
}
