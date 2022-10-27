using System.ComponentModel.DataAnnotations;

namespace ContosoRazorAm.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public int StudentID { get; set; }
        
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // Navigation Properties

        public Module Module { get; set; }
        public Student Student { get; set; }
    }
}
