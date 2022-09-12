using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPIEnrollmentSystem.Models
{
    public class StudentRequirement
    {
        [Key, Column(Order = 0)]
        public int StudentID { set; get; }

        [Key, Column(Order = 1)]
        public int RequirementId { set; get; }

        public virtual Student Student { set; get; }
        public virtual Requirement Requirement { set; get; }
    }
}
