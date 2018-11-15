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
                Console.WriteLine(ex.Message);
                return null;
            }
            return room;
        }
        public bool IsSlotAvailable(Slot slot) {
            try {
                Slot result = new Slot();
                DataTable dt = new DataTable();
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "select * from Slot where roomID=@roomID and slotNumber = @slot";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@roomID", slot.RoomID);
                    cmd.Parameters.AddWithValue("@slot", slot.Number);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    conn.Close();
                }
                return dt.Rows[0][3].ToString() == "True";
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
        public static List<int> GenerateYear() {
            List<int> result = new List<int>();
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= currentYear - 7; year--) result.Add(year);
            return result;
        }

        public int CreateIfNotExist(string studentID, int month, int year) {
            try {
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "if (select COUNT(*) from StudentStatus where studentID = @studentID and [month] = @month and [year] = @year) = 0 "
                    + "insert into StudentStatus(studentID, [month], [year], electricCost, waterCost, extraFee, isCompleteFee) "
                    + "values(@studentID, @month, @year, 0, 0, 0, 0)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@studentID", studentID);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int UpdateStudentStatus(StudentStatus studentStatus) {
            try {
                string query = "update StudentStatus set electricCost = @electric, waterCost = @water, extraFee = @extra, extraFeeContent = @extraInfo, isCompleteFee = @complete, note = @info where studentID = @studentID and[month] = @month and[year] = @year";
                using (SqlConnection conn = DBUtil.getConnection) {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@electric", studentStatus.ElectricCost);
                    cmd.Parameters.AddWithValue("@water", studentStatus.WaterCost);
                    cmd.Parameters.AddWithValue("@extra", studentStatus.ExtraFee);
                    cmd.Parameters.AddWithValue("@extraInfo", studentStatus.ExtraNote);
                    cmd.Parameters.AddWithValue("@studentID", studentStatus.StudentID);
                    cmd.Parameters.AddWithValue("@month", studentStatus.Month);
                    cmd.Parameters.AddWithValue("@year", studentStatus.Year);
                    cmd.Parameters.AddWithValue("@complete", studentStatus.Complete);
                    cmd.Parameters.AddWithValue("@info", studentStatus.Note);
                    conn.Open();
                    return cmd.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public StudentStatus GetStudentStatus(string studentID, int month, int year) {
            StudentStatus studentStatus = new StudentStatus();
            try {
                CreateIfNotExist(studentID, month, year);
                DataTable dt = new DataTable();
                using (SqlConnection conn = DBUtil.getConnection) {
                    string query = "select * from StudentStatus where studentID = @studentID and month = @month and year = @year";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentID", studentID);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    studentStatus.StudentID = studentID;
                    studentStatus.Month = month;
                    studentStatus.Year = year;
                    studentStatus.ElectricCost = double.Parse(dt.Rows[0][3].ToString());
                    studentStatus.WaterCost = double.Parse(dt.Rows[0][4].ToString());
                    studentStatus.ExtraFee = double.Parse(dt.Rows[0][5].ToString());
                    studentStatus.ExtraNote = dt.Rows[0][6].ToString();
                    Console.WriteLine("EEE" + dt.Rows[0][7].ToString());
                    studentStatus.Complete = dt.Rows[0][7].ToString() == "True" ? true : false;
                    studentStatus.Note = dt.Rows[0][8].ToString();

                    return studentStatus;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


    }
}
