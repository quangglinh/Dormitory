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

        public StudentStatus getStudentStatus(string studentID)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT Slot.studentID, name, slotNumber, Slot.roomID, dom FROM dbo.Student "
                + "INNER JOIN dbo.Slot ON Slot.studentID = Student.studentID "
                + "INNER JOIN dbo.Room ON Room.roomID = Slot.roomID WHERE Student.studentID=@studentID";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@studentID", studentID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable statusTable = new DataTable();
                da.Fill(statusTable);
                DataRow row = statusTable.Rows[0];
                string name = row["name"].ToString();
                int slotNumber = 0;
                try {
                    int.TryParse(row["slotNumber"].ToString(), out slotNumber);
                } catch
                {

                }
                string roomID = row["roomID"].ToString();
                string dom = row["dom"].ToString();
                StudentStatus student = new StudentStatus(studentID, name, dom, roomID, slotNumber);
                return student;
            }
        }
        public DataTable getYearByStudentExtra(string studentID)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT year FROM dbo.StudentStatus WHERE studentID=@studentID";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@studentID", studentID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
        public DataTable getMonthByStudentExtra(string studentID, int year)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT month FROM dbo.StudentStatus " 
                    + "WHERE studentID=@studentID and year=@year";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@year", year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
        public DataRow getBillhByStudentExtra(string studentID, int year, int month)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT * FROM dbo.StudentStatus "
                    + "WHERE studentID=@studentID and year=@year and month=@month";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@month", month);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                DataRow row = table.Rows[0];
                return row;
            }
        }
    }
}
