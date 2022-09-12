using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPIEnrollmentSystem.Models
{
    // NOT FINAL, NEED TUITION
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        [Required]
        [ForeignKey("AcademicYear")]
        public int AcademicYearID { get; set; }
        [Required]
        [ForeignKey("Strand")]
        public int StrandID { get; set; }

        public virtual Student Student { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual Strand Strand { get; set; }


        public DateTime EnrollmentDate { get; set; }
        public int GradeLevel { get; set; }
        public string Status { get; set; }
    }
}
