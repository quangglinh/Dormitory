using DormintoryStudentApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DormintoryStudentApp.Supporting_Files;
namespace DormintoryStudentApp.Model
{
    class StudentDAL
    {
        public StudentAccount studentLogin(string username, string password)
        {
            StudentAccount theAccount = null;
            using(SqlConnection conn = DBUltiity.getConnection) 
            {
                string query = "SELECT * FROM StudentAccount WHERE username=@username AND password=@password";
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // query successfully
                    string studentID = reader.GetString(2);
                    // string phone = reader.GetString(3);
                    string phone = "123456";
                    Console.WriteLine(reader.GetString(2));
                    theAccount = new StudentAccount(username, password, studentID);
                }
                reader.Close();
                // return student
                return theAccount;

            }
        } // end studentLogin

        public Student getTheStudent(string studentID)
        {
            Student theStudent = null;
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT * FROM Student WHERE studentID=@studentID";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@studentID", studentID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // query successfully
                    string name = reader.GetString(1);
                    string email = reader.GetString(2);
                    string phone = reader.GetString(3);
                    Console.WriteLine(reader.GetString(2));
                    theStudent = new Student(studentID, name, email, phone);
                }
                reader.Close();
                // return student
                return theStudent;

            }
        } // end getTheStudent

    }
}
