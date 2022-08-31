namespace ASPNetCoreWeek1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StuFirstName { get; set; }
        public string StuLastName { get; set; }

        public string Email{ get; set; }
        public string PhoneNumber { get; set; }

       public List<Student> InStudents { get; set; }
    }
}