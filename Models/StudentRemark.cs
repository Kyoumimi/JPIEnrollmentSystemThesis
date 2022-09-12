﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPIEnrollmentSystem.Models
{
    // Variable
    public class StudentRemark
    {
        [Key, Column(Order = 0)]
        public int StudentID { set; get; }

        [Key, Column(Order = 1)]
        public int SubjectId { set; get; }

        public virtual Student Student { set; get; }
        public virtual Subject Subject { set; get; }
        public string Remark { get; set; }
    }
}
