using Microsoft.AspNetCore.Mvc;
using ASPNetCoreWeek1.Models;
using ASPNetCore.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
