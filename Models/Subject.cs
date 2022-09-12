
using System.Collections.Generic;

namespace JPIEnrollmentSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public float Unit { get; set; }
        public virtual ICollection<StrandSubjects> StrandSubjects { get; set; }
        public virtual ICollection<Class> Class { get; set; }
        public virtual ICollection<StudentRemark> StudentRemark { get; set; }
    }
}
