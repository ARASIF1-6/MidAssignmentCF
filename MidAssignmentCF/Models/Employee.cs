using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidAssignmentCF.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name can't be blank")]
        [Display(Name = "Please Enter the Employee Name")]
        [MaxLength(50, ErrorMessage = "Not more than 50 alphabets")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date can't be blank")]
        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Required(ErrorMessage = "Salary can't be blank")]
        [Display(Name = "Salary")]
        [Range(1000, 60000, ErrorMessage = "Salary range can be between 1000 to 60000")]
        public float Salary { get; set; }

        [Required(ErrorMessage = "Department Name can't be blank")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}