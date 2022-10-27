namespace ContosoRazorAm.Models
{
    public class Module
    {
        public int ID { get; set; }
        public string Code { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public int Credits { get; set; }

        // Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
