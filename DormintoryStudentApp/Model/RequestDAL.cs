using DormintoryStudentApp.Supporting_Files;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Model
{
    class RequestDAL
    {
        // insert to complain table
        public bool addComplain(string studentID, string fromSlot, string atRoom, string reason, string statusID )
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "INSERT INTO ProblemComplain VALUES(@studentID, @fromSlot, @atRoom, @reason, @statusID, @createdTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@fromSlot", fromSlot);
                cmd.Parameters.AddWithValue("@atRoom", atRoom);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@statusID", statusID);
                cmd.Parameters.AddWithValue("@createdTime", DateTime.Now);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool addChangeRoomRequest(string studentID, string fromSlot, string atRoom, string reason, string toSlot, string toRoom, string statusID)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "INSERT INTO ChangeRoomRequest VALUES(@studentID, @fromSlot, @atRoom, @toSlot, @toRoom, @reason, @statusID, @createdTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@fromSlot", fromSlot);
                cmd.Parameters.AddWithValue("@atRoom", atRoom);
                cmd.Parameters.AddWithValue("@toSlot", toSlot);
                cmd.Parameters.AddWithValue("@toRoom", toRoom);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@statusID", statusID);
                cmd.Parameters.AddWithValue("@createdTime", DateTime.Now);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool addLeaveRoomRequest(string studentID, string fromSlot, string atRoom, string statusID)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "INSERT INTO LeaveRoomRequest VALUES(@studentID, @fromSlot, @atRoom, @statusID, @createdTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@fromSlot", fromSlot);
                cmd.Parameters.AddWithValue("@atRoom", atRoom);
                cmd.Parameters.AddWithValue("@statusID", statusID);
                cmd.Parameters.AddWithValue("@createdTime", DateTime.Now);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

    }
}
