namespace ContosoRazorAm.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; }  = string.Empty;
        public DateTime EnrollmentDate { get; set; }

        // Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
