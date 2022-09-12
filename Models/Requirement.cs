
using System.Collections.Generic;

namespace JPIEnrollmentSystem.Models
{
    public class Requirement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StudentRequirement> StudentRequirements { get; set; }
    }
}
