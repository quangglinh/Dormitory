using DormintoryStudentApp.Entity;
using DormintoryStudentApp.Supporting_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Model
{
    class RoomDAL
    {
        public DataTable getListOfDom()
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT dom From Room ORDER BY dom ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable domTable = new DataTable();
                da.Fill(domTable);
                return domTable;
            }
        } // end getListOfDom

        public DataTable getCapacityList()
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT numberOfSlot From Room ORDER BY numberOfSlot ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable capacityTable = new DataTable();
                da.Fill(capacityTable);
                return capacityTable;
            }
        } // end get capacity list

        public DataTable getAllAvailableSlot()
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT r.roomID as Room, s.slotNumber as Slot, r.dom as AtDom, r.monthlyFee as MonthlyFee, r.numberOfSlot as Capacity FROM Room r INNER JOIN Slot s ON r.roomID = s.roomID WHERE s.isAvailable = 1 ORDER BY Room ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable allAvailableSlotTable = new DataTable();
                da.Fill(allAvailableSlotTable);
                return allAvailableSlotTable;

            }

        } // end get all available room

        public DataTable getAvailableRoomByInput(string input)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT r.roomID as Room, s.slotNumber as Slot, r.dom as AtDom, r.monthlyFee as MonthlyFee, r.numberOfSlot as Capacity FROM Room r INNER JOIN Slot s ON r.roomID = s.roomID WHERE r.roomID=@input AND s.isAvailable = 1 ORDER BY Room ASC";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@input", input);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable allAvailableSlotTable = new DataTable();
                da.Fill(allAvailableSlotTable);
                return allAvailableSlotTable;
            }

        } // end get available room by input


        public DataTable getAvailableRoomByProperty(string dom, int capacity)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT r.roomID as Room, s.slotNumber as Slot, r.dom as AtDom, r.monthlyFee as MonthlyFee, r.numberOfSlot as Capacity FROM Room r INNER JOIN Slot s ON r.roomID = s.roomID WHERE r.dom = @dom AND r.numberOfSlot = @capacity AND s.isAvailable = 1 ORDER BY Room ASC";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@dom", dom);
                cmd.Parameters.AddWithValue("@capacity", capacity);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable allAvailableSlotTable = new DataTable();
                da.Fill(allAvailableSlotTable);
                return allAvailableSlotTable;
            }

        }

        public bool isRoomExisted(string input)
        {
            using(SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT * FROM Room WHERE roomID=@roomID";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@roomID", input);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;

            }
        } // end isRoomExisted

        public Slot getSlotByStudentID(string studentID)
        {
            
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                Slot theSlot = new Slot();
                string query = "SELECT * FROM Slot WHERE studentID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", studentID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    theSlot.slotNumber = int.Parse(dt.Rows[0][0].ToString());
                    theSlot.roomID = dt.Rows[0][1].ToString();
                    theSlot.studentID = dt.Rows[0][2].ToString();
                    theSlot.isAvailable =  bool.Parse(dt.Rows[0][3].ToString());
                }
                return theSlot;
            }
           
        }

        public DataTable getAllRoomWhichHaveAvailableSlot( )
        {

            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT Slot.roomID FROM Slot WHERE isAvailable = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public DataTable getAvailableSlotByRoomName(string roomName)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT Slot.slotNumber FROM Slot WHERE roomID = @roomName AND isAvailable = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@roomName", roomName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
