using System.ComponentModel.DataAnnotations;
using Registrar;

namespace Registrar
{
    public class Student
    {
        public int Id { get; set; } = new Random().Next(1000, 9999);
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; } = "";
        [Required(ErrorMessage = "Type is Required")]
        public string Type { get; set; } = "";
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
   
}
