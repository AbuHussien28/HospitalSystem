using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHospitalSystem.Models.DTO
{
    public class DepartmentDTO
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }
        public decimal FeeAmount { get; set; }
        public string ManagingDoctor { get; set; }
    }
}
