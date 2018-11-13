using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormitoryManager.AppCode {

    class Student {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    class Room {
        public string ID { get; set; }
        public string Dom { get; set; }
        public double Fee { get; set; }
        public int NoSlot { get; set; }
    }

    class Slot {
        public string RoomID { get; set; }
        public string StudentID { get; set;}
        public bool Available { get; set; }
        public int Number { get; set; }
    }
}
