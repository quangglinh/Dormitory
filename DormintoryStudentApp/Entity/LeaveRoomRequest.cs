using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    class LeaveRoomRequest
    {
        public string studentID { get; set; }
        public int fromSlot { get; set; }
        public string atRoom { get; set; }
        public int statusID { get; set; }
    }
}
