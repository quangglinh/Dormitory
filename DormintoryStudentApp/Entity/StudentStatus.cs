using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    class StudentStatus
    {
        public string studentID { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public double electricCost { get; set; }
        public double waterCost { get; set; }
        public double extraFee { get; set; }
        public string extraFeeContent { get; set; }

    }
}
