using DormintoryStudentApp.Supporting_Files;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Model
{
    class StudentAccountDAL
    {
        public bool validCurrentPassword(string currentPassword, string username)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT * FROM StudentAccount WHERE password=@password AND username=@username ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", currentPassword);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }

        public bool validConfirmPassword(string newPass, string oldPass)
        {
            return newPass.Equals(oldPass);
        }

        public bool changePassword(string newPass, string studentID )
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "UPDATE StudentAccount SET password=@newpass WHERE studentID=@id ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newpass", newPass);
                cmd.Parameters.AddWithValue("@id", studentID);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;

            }
        }

    }
}
