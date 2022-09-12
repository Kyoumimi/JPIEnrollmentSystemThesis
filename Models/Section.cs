using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPIEnrollmentSystem.Models
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        [Required]
        [ForeignKey("Strand")]
        public int StrandID { get; set; }
        public Strand Strand { get; set; }
        public string SectionName { get; set; }
        public string GradeLevel { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        
        public virtual ICollection<Class> Class { get; set; }
    }
}
