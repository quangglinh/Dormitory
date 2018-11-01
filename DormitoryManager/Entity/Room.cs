using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormitoryManager.Entity {
    class Room {
        public string ID { get; set; }
        public string Dom { get; set; }
        public string MonthlyFee { get; set; }
        public int NumberOfSlot { get; set; }
    }

    class Slot {
        public string SlotNumber { get; set; }
        public string RoomID { get; set; }
        public string StudentID { get; set; }
        public bool Available { get; set; }

    }
