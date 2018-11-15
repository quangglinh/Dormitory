using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Entity
{
    public class StudentAccount
    {
        public StudentAccount(string username, string password, string studentID)
        {
            this.username = username;
            this.password = password;
            this.studentID = studentID;
        }

        public StudentAccount()
        {
            
        }

        public string username { get; set; }
        public string password { get; set; }
        public string studentID { get; set; }



    }
}
