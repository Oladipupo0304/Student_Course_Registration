namespace Student_Course_Registration.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Email  { get; set; }
        public string? Password { get; set; }
        public ICollection<Registration>? Registrations { get; set; }

    }
}
