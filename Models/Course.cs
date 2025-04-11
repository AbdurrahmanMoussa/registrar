namespace Registrar;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Registrar;

public class Course
{
  [Key]
  public int Id { get; set; }
  public string Code { get; set; } = "";
  public string Title { get; set; } = "";
  public int WeeklyHours { get; set; }
  //public bool isEnrolled { get; set; } = false;
  public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    public override string ToString()
  {
      return Code + " " + Title + " " + WeeklyHours.ToString() + (WeeklyHours==1 ? "hour":" hours") + " per week";
  }
}
