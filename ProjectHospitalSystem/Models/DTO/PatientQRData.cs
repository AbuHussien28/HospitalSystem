﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models.DTO
{
    public class PatientQRData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MedicalHistory { get; set; }
        public string Diaqnois { get; set; }
        public string LabResult { get; set; }
        public string Prescription { get; set; }
        public string TreatmentDetails { get; set; }
    }
}
