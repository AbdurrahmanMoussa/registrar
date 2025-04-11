using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registrar
{
    public class Registration
    {
     
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

    }
}
