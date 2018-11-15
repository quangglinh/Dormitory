using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DormitoryManager.AppCode
{
    class DataAccess
    {
        //get manager id
        public DataTable LoadManager(string username, string password)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from ManagerAccount " +
                    "where username = @username " +
                    "and password = @password", connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        //Add new Room
        public void AddNewRoom(string roomId, string dom, float fee, int slot)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                // add new room
                SqlCommand cmd = new SqlCommand("Insert into Room " +
                    "values(@roomId, @dom, @fee, @slot)", connection);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@dom", dom);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@slot", slot);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                //add new slots
                for (int i = 0; i < slot; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into Slot " +
                    "values(@slotNumber,@roomId,null,1)", connection);
                    cmd1.Parameters.AddWithValue("@slotNumber", i + 1);
                    cmd1.Parameters.AddWithValue("@roomId", roomId);
                    connection.Open();
                    cmd1.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        //Load Rooms
        public DataTable LoadRooms()
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                DataTable dt = new DataTable();
                string query = "Select roomID from Room";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
                return dt;
            }
        }


        //Load Room Information
        public DataTable LoadRoomInfo(string roomId)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                DataTable dt = new DataTable();
                string query = "Select * from Room where roomID = '"+roomId+"'";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                
                da.Fill(dt);
                return dt;
            }
        }

        //Load Available slots of a room
        public DataTable LoadAvailableSlots(string roomId)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                DataTable dt = new DataTable();
                string query = "Select slotNumber from Room r " +
                    "inner join Slot s on r.roomID = s.roomID " +
                    "where r.roomID = '"+roomId+"' and s.isAvailable = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);

                da.Fill(dt);
                return dt;
            }
        }

        //Load student request info
        public DataTable LoadStudentRequests()
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                DataTable dt = new DataTable();
                string query = "select requestID from ChangeRoomRequest";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
                return dt;
            }
        }

        //Load student request info
        public DataTable LoadStudentRequestInfo(string requestID)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                DataTable dt = new DataTable();
                string query = "select c.requestID,s.studentID,s.name,c.fromSlot,c.atRoom,c.toSlot,c.toRoom,c.reason,w.[status],w.statusID from " +
                    "Student s inner join ChangeRoomRequest c on s.studentID = c.studentID " +
                    "inner join WorkStatus w on c.statusID = w.statusID where c.requestID= " + requestID;
                SqlDataAdapter da = new SqlDataAdapter(query,connection);
                da.Fill(dt);
                return dt;
            }
        }

        //Update request
        public void UpdateRequest(int requestId, int statusId)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                // add new room
                SqlCommand cmd = new SqlCommand("Update ChangeRoomRequest set statusID = @statusId " +
                    "where requestID = @requestId", connection);
                cmd.Parameters.AddWithValue("@statusId", statusId);
                cmd.Parameters.AddWithValue("@requestId", requestId);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Update request
        public void UpdateFee(string roomId, float fee)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                SqlCommand cmd = new SqlCommand("Update Room set monthlyFee = @fee " +
                    "where roomID = @roomID", connection);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@roomID", roomId);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}   
