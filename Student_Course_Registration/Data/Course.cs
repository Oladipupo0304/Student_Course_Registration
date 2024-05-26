namespace Student_Course_Registration.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CoureName { get; set; }
        public string? Decsription { get; set; }
        public required ICollection<Registration> Registrations { get; set; }
    }
}
