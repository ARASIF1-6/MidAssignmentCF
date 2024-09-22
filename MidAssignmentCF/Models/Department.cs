using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidAssignmentCF.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name can't be blank")]
        [Display(Name = "Please Enter the Department Name")]
        [MaxLength(50, ErrorMessage = "Not more than 50 alphabets")]
        public string DepartmentName { get; set; }
    }
}