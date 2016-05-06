using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC40_Knockout_App.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int EmpNo { get; set; }

        [MaxLength(50)]
        public string EmpName { get; set; }

        public decimal Salary { get; set; }

        [MaxLength(50)]
        public string DeptName { get; set; }

        [MaxLength(50)]
        public string Designation { get; set; }
    }

}