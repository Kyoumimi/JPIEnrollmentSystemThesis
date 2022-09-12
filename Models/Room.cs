﻿
using System.Collections.Generic;

namespace JPIEnrollmentSystem.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public virtual ICollection<Class> Class { get; set; }
    }
}
