using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormitoryManager.Entity {
    class Student {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    class StudentStatus {
        public string ID { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string ElectricCost { get; set; }
        public string WaterCost { get; set; }
        public string ExtraFee { get; set; }
        public string ExtraFeeContent { get; set; }
    }
}
}
