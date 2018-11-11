using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    class StudentStatus
    {
        private string studentID;
        private string studentName;
        private string dom;
        private int slot;
        private string room;

        public string StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }
        public string StudentName
        {
            get { return this.studentName; }
            set { this.studentName = value; }
        }
        public string Dom
        {
            get { return this.dom; }
            set { this.dom = value; }
        }
        public int Slot
        {
            get { return this.slot; }
            set { this.slot = value; }
        }
        public string Room
        {
            get { return this.room; }
            set { this.room = value; }
        }
        public StudentStatus(string StudentID, string StudentName, string Dom, string Room, int Slot)
        {
            this.studentID = StudentID;
            this.studentName = StudentName;
            this.dom = Dom;
            this.slot = Slot;
            this.room = Room;
        }
    }
}
