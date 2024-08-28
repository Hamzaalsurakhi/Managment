using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Managment.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Please Enter Employee Name ")]
        [MinLength(3,ErrorMessage ="Minimum number of char 3")]
        [MaxLength(20,ErrorMessage ="Max 20 char")]
        public string Name { get; set; }

        public DateTime HDate { get; set; }

        [Required(ErrorMessage ="Enter Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        public decimal Salary { get; set; }

        
        public string City { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
