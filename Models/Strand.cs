using System.Collections.Generic;

namespace JPIEnrollmentSystem.Models
{
    public class Strand
    {
        public int StrandId { get; set; }
        public string StrandName { get; set; }
        public string Description { get; set; }
        public ICollection<StrandSubjects> Subject { get; set; }
        public ICollection<Section> Section { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
