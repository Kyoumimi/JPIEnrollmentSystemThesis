using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPIEnrollmentSystem.Models
{
    public class StrandSubjects
    {
        [Key, Column(Order = 0)]
        public int StrandID { set; get; }

        [Key, Column(Order = 1)]
        public int SubjectId { set; get; }

        public virtual Strand Strand { set; get; }
        public virtual Subject Subject { set; get; }
        public int GradeLevel { set; get; }
        public string Term { set; get; }
    }
}
