namespace Registrar;

public class Helper
{
  public static List<Course> GetCourses ()
  {
    List<Course> courses = [];

    Course course = new Course
    {
      Code = "CST8282",
      Title = "Introduction to Database Systems",
      WeeklyHours = 4
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8253",
      Title = "Web Programming II",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8256",
      Title = "Web Programming Language I",  
      WeeklyHours = 5
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8255",
      Title = "Web Imaging and Animations",  
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8254",
      Title = "Network Operating System",  
      WeeklyHours = 1
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2200",
      Title = "Data Warehouse Design",  
      WeeklyHours = 3
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2240",
      Title = "Advance Database topics",  
      WeeklyHours = 1
    };
    courses.Add(course);   

    return courses;
  }

  public static List<string> GetStudentTypes () {
    return ["Full Time", "Part Time", "Coop"];
  }
   public static List<Student> InitialStudents =
    [
        new Student { Id = 1, FirstName = "Bob", LastName = "Builder", Type = GetStudentTypes()[1] },
        new Student { Id = 2, FirstName = "Bob", LastName = "Builder", Type = GetStudentTypes()[2] },
        new Student { Id = 3, FirstName = "Bob", LastName = "Builder", Type = GetStudentTypes()[2] },
        new Student { Id = 4, FirstName = "Bob", LastName = "Builder", Type = GetStudentTypes()[2] },
        new Student { Id = 5, FirstName = "Bob", LastName = "Builder", Type = GetStudentTypes()[1] },
        new Student { Id = 6, FirstName = "Bob", LastName = "Builder", Type = GetStudentTypes()[2] }
    ];

    //public static List<Student> GetStudents()
    //  {
    //      List<Student> students = [];

    //      Student student = new Student
    //      {
    //          Id = 1,
    //          FirstName="Bob",
    //          LastName="Builder",
    //          Type = GetStudentTypes()[1],

    //      };
    //      students.Add(student);
    //      student = new Student
    //      {
    //          Id = 2,
    //          FirstName = "Bob",
    //          LastName = "Builder",
    //          Type = GetStudentTypes()[2],

    //      };
    //      students.Add(student);
    //      student = new Student
    //      {
    //          Id = 3,
    //          FirstName = "Bob",
    //          LastName = "Builder",
    //          Type = GetStudentTypes()[2],

    //      };
    //      students.Add(student);
    //      student = new Student
    //      {
    //          Id = 4,
    //          FirstName = "Bob",
    //          LastName = "Builder",
    //          Type = GetStudentTypes()[2],

    //      };
    //      students.Add(student);

    //      student = new Student
    //      {
    //          Id = 5,
    //          FirstName = "Bob",
    //          LastName = "Builder",
    //          Type = GetStudentTypes()[1],

    //      };
    //      students.Add(student);
    //      student = new Student
    //      {
    //          Id = 6,
    //          FirstName = "Bob",
    //          LastName = "Builder",
    //          Type = GetStudentTypes()[2],

    //      };
    //      students.Add(student);
    //      return students;
    //  }
}
