using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation.Models
{
    public class NewEmp
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Employee Name")]
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Employee Age")]
        [Display(Name = "Age")]
        [Range(18,60)]
        public string Age { get; set; }

        [Required(ErrorMessage = "Enter Employee Salary")]
        [Display(Name = "Salary")]
        public string Salary { get; set; }

    }
}
