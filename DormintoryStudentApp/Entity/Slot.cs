using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    class Slot
    {
        public int slotNumber { get; set; }
        public string roomID { get; set; }
        public string studentID { get; set; }
        public bool isAvailable { get; set; }
    }
}
