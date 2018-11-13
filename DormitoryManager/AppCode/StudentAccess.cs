using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DormitoryManager.AppCode {
    class StudentAccess : DataAccess {
        public bool isStudentAvailable(string Id) {
            try {
                DataTable dt = new DataTable();
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "select COUNT(roomID) from Slot where studentID = @ID and isAvailable = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", Id);
                    conn.Open();
                    SqlDataAdapter adaper = new SqlDataAdapter(cmd);
                    adaper.Fill(dt);
                    conn.Close();
                }
                return Int32.Parse(dt.Rows[0][0].ToString()) == 0;

            } catch (Exception ex) {
                return false;
            }

        }

        public Room GetRoom(string id) {
            Room room = new Room();
            try {
                DataTable dt = LoadRoomInfo(id);
                String dom = dt.Rows[0][1].ToString();
                double fee = double.Parse(dt.Rows[0][2].ToString());
                int noS = int.Parse(dt.Rows[0][3].ToString());
                room.ID = id;
                room.Dom = dom;
                room.Fee = fee;
                room.NoSlot = noS;

            } catch (Exception ex) {
                return null;
            }

            return room;
        }

        public Slot getSlot(string studentID) {
            try {
                Slot result = new Slot();
                DataTable dt = new DataTable();
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "select * from Slot where studentID=@studentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentID", studentID);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    conn.Close();
                }
                result.StudentID = studentID;
                result.RoomID = dt.Rows[0][1].ToString();
                result.Number = int.Parse(dt.Rows[0][0].ToString());
                result.Available = false;

                return result;
            } catch (Exception ex) {
                return null;
            }
        }

        public int Checkout(string studentId) {
            try {
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "update Slot set studentID=null, isAvailable= 1 where studentID=@studentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentID", studentId);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                return 0;
            }
        }

        

        public int Checkin(string studentId, string roomID, int slot) {
            try {
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "update Slot set studentID = @studentID, isAvailable = 0 where roomID = @roomID and slotNumber = @slot";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentID", studentId);
                    cmd.Parameters.AddWithValue("@roomID", roomID);
                    cmd.Parameters.AddWithValue("@slot", slot);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                return 0;
            }
        }

        public Student GetStudent(string Id) {
            
            Student result = new Student();
            try {
                DataTable dt = new DataTable();
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "select studentID, name, email, phone from Student where studentID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", Id);
                    conn.Open();
                    SqlDataAdapter adaper = new SqlDataAdapter(cmd);
                    adaper.Fill(dt);
                    conn.Close();
                }
                result.Id = dt.Rows[0][0].ToString();
                result.Name = dt.Rows[0][1].ToString();
                result.Email = dt.Rows[0][2].ToString();
                result.Phone = dt.Rows[0][3].ToString();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            return result;
        }
    }
}
