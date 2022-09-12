using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPIEnrollmentSystem.Models
{
    public class Class
    {
        [Key, Column(Order = 0)]
        public int SectionID { set; get; }

        [Key, Column(Order = 1)]
        public int SubjectId { set; get; }

        [Key, Column(Order = 2)]
        public int RoomId { set; get; }

        [Key, Column(Order = 3)]
        public int EmployeeId { set; get; }


        public virtual Section Section { set; get; }
        public virtual Subject Subject { set; get; }
        public virtual Room Room { set; get; }
        public virtual Employee Employee { set; get; }
    }
}
