using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class EmpployeeVM
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Ad boş geçilemez!")]
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public int? ReportTo { get; set; }
    }
}
