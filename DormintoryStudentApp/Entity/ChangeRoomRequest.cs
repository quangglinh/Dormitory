using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    class ChangeRoomRequest
    {
        public string studentID { get; set; }
        public int fromSlot { get; set; }
        public string atRoom { get; set; }
        public int toSlot { get; set; }
        public string toRoom { get; set; }
        public string reason { get; set; }
        public int statusID { get; set; }
    }
}
