using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    public class Student
    {
        public string studentID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public Student(string studentID, string name, string email, string phone)
        {
            this.studentID = studentID;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public Student()
        {

        }

    }
}
