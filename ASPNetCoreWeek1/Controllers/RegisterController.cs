using Microsoft.AspNetCore.Mvc;
using ASPNetCoreWeek1.Models;
using ASPNetCore.Models;
using Microsoft.EntityFrameworkCore;
using ASPNetCore.DTO;

namespace ASPNetCore.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterContext _context;



        public RegisterController()
        {

            _context = new RegisterContext();
           


        }

        public IActionResult Courses()
        {
            var courses = _context.Courses.Include(c => c.Students1).ToList();
            return View(courses);
        }

        public IActionResult Professors()
        {
            var professors = _context.Professors.ToList();
            return View(professors);
        }
        public IActionResult Students()
        {
            var students = _context.Students.ToList(); 
            return View(students);
        }
        public IActionResult CourseRegistration()
        {
            
            return View();
        }
        public IActionResult SaveCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction(nameof(Courses));
        }
        public IActionResult StudentRegistration()
        {

            return View();
        }

        public IActionResult SaveStudent(StudentDTO studentDTO)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseId == studentDTO.CourseId);

            var student = new Student
            {
                
                StuFirstName = studentDTO.StuFirstName,
                StuLastName = studentDTO.StuLastName,
                Email = studentDTO.Email,
                PhoneNumber = studentDTO.PhoneNumber,
                Courses = new List<Course>()
            };

            if (course != null)
            {
                student.Courses.Add(course);
            }
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction(nameof(Students));

        }
        public IActionResult ProfessorRegistration()
        {

            return View();
        }
        public IActionResult SaveProfessor(Professor professor)
        {
            _context.Professors.Add(professor);
            _context.SaveChanges();

            return RedirectToAction(nameof(Professors));

        }

    }
}
