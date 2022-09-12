using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JPIEnrollmentSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }    
        public int GradeLevel { get; set; }
        public string Strand { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string LRN { get; set; }
        public string Religion { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Elem { get; set; }
        public string ElemInclusiveYears { get; set; }
        public int ElemYearGraduated { get; set; }
        public string Jhs { get; set; }
        public string JhsInclusiveYears { get; set; }
        public int JhsYearGraduated { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherContacNo { get; set; }
        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public string MotherContactNo { get; set; }
        public string GuardianName { get; set; }
        public string GuardianRelation { get; set; }
        public string GuardianContacNo { get; set; }
        public virtual ICollection<StudentRequirement> StudentRequirement { get; set; }
        public virtual ICollection<StudentRemark> StudentRemark { get; set; }
    }
}
