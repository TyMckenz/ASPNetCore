using ASPNetCoreWeek1.Models;

namespace ASPNetCore.DTO
{
    public class StudentDTO
    {
        public string StuFirstName { get; set; }
        public string StuLastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CourseId { get; set; }
        public List<Course> Courses { get; set; }
    }
}
