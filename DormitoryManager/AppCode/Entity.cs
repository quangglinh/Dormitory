using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormitoryManager.AppCode {

    public class StudentStatus {
        public string StudentID { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double ElectricCost { get; set; }
        public double WaterCost { get; set; }
        public double ExtraFee { get; set; }
        public string ExtraNote { get; set; }
        public bool Complete { get; set; }
        public string Note { get; set; }
    }
    public class Student {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class Room {
        public string ID { get; set; }
        public string Dom { get; set; }
        public double Fee { get; set; }
        public int NoSlot { get; set; }
    }
    public class Slot {
        public string RoomID { get; set; }
        public string StudentID { get; set; }
        public bool Available { get; set; }
        public int Number { get; set; }
    }
}
