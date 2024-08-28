using System.ComponentModel.DataAnnotations;

namespace Managment.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }
    }
}
