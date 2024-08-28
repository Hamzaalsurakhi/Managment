using System.ComponentModel.DataAnnotations;

namespace Managment.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }
        [Required(ErrorMessage ="Enter Course Name")]
        public string CourseName { get; set; }

        public string Period { get; set; }
        [DataType(DataType.Date)]
        public DateTime SDate { get; set; }

        public int Hours { get; set; }
    }
}
