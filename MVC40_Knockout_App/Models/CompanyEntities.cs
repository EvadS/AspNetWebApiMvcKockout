using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC40_Knockout_App.Models
{
    public class CompanyEntities   :DbContext
    {
        public DbSet<EmployeeInfo> EmployeeInfoes { get; set; }
    }
}