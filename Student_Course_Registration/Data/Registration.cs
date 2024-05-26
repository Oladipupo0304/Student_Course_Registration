namespace Student_Course_Registration.Data
{
    public class Registration
    {
      
        
      
        public int RegistrationID { get; set; }
        public int StudentId { get; set; }
        public int CourseID { get; set; }
        public string? Status { get; set; }
        public DateTime RegistrationDate { get; set; }
       
        public Student? Student { get; set; }
        public Course? Course { get; set; }

    }
}
