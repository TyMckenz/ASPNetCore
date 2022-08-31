namespace ASPNetCore.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseNum { get; set; }
        public string Description { get; set; }

        public List<Student> Students1 { get; set; }
    }
}
