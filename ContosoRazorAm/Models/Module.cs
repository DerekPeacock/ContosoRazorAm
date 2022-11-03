using System.ComponentModel.DataAnnotations;

namespace ContosoRazorAm.Models
{
    public class Module
    {
        public int ID { get; set; }
        
        [Required, StringLength(20)]
        public string Code { get; set; } = String.Empty;

        [Required, StringLength(60)]
        public string Title { get; set; } = String.Empty;

        [Range(0, 30)]
        public int Credits { get; set; }

        // Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
