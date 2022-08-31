using Microsoft.AspNetCore.Mvc;
using ASPNetCoreWeek1.Models;

namespace ASPNetCore.Controllers
{
    public class RegisterController : Controller
    {
        public List<Course> courses;
        public List<Professor> professor;
        public List<Student> students;

        public RegisterController()
        {
            courses = new List<Course>()
            {
                new Course
                {
                    CourseId = 1,
                    CourseName = "Astronomy",
                    CourseNum = 551,
                    Description = "Looking At The Sky For Shapes",
                    Students1 = new List<Student>
                    {
                        new Student
                        {
                            StudentId = 221,
                            StuFirstName = "Bing",
                            StuLastName = "Williams",
                            Email = "bingwill@yuyu.cu",
                            PhoneNumber = "111-222-3333"

                        },
                        new Student
                        {
                            StudentId = 222,
                            StuFirstName = "Phil",
                            StuLastName = "Bong",
                            Email = "philbo@yuyu.cu",
                            PhoneNumber = "111-333-4444"

                        }
                    }
                },

                    new Course
                {
                    CourseId = 2,
                    CourseName = "Computer Racing",
                    CourseNum = 552,
                    Description = "See If You Can Beat A Robot In A Race",
                    Students1 = new List<Student>
                    {
                        new Student
                        {
                            StudentId = 221,
                            StuFirstName = "Bing",
                            StuLastName = "Williams"

                        },
                        new Student
                        {
                            StudentId = 222,
                            StuFirstName = "Phil",
                            StuLastName = "Bong"
                      
                        }
                    }
                   
                }
                    
            };

            students = new List<Student>
            {
                  new Student
                  {
                      StudentId = 221,
                      StuFirstName = "Bing",
                      StuLastName = "Williams",
                      Email = "bingwill@yuyu.cu",
                      PhoneNumber = "111-222-3333"

                  },
                  new Student
                  {
                      StudentId = 222,
                      StuFirstName = "Phil",
                      StuLastName = "Bong",
                      Email = "philbo@yuyu.cu",
                      PhoneNumber = "111-333-4444"

                  }

            };
            

            professor = new List<Professor>()
            {
                new Professor
                {
                    ProfId = 110,
                    ProfFirstName = "Jah",
                    ProfLastName = "Hoorah",
                    CourseId = 1

                },
                new Professor
                {
                    ProfId = 111,
                    ProfFirstName = "Borg",
                    ProfLastName = "Cyberson",
                    CourseId= 2
                }

            };

           
        }
        
        public IActionResult Courses()
        {
           
            return View(courses);
        }

        public IActionResult Professors()
        {
            return View(professor);
        }
        public IActionResult Students()
        {
            return View(students);
        }
    }
}
