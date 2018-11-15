using DormintoryStudentApp.Entity;
using DormintoryStudentApp.Supporting_Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormintoryStudentApp.UI
{
    public partial class ChangeRoomRequestHistory : Form
    {
        Student theStudent;
        public ChangeRoomRequestHistory()
        {
            InitializeComponent();
        }
        public ChangeRoomRequestHistory(Student theStudent)
        {
            InitializeComponent();
            this.theStudent = theStudent;
        }

        private void ChangeRoomRequestHistory_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT request.studentID, request.fromSlot, request.atRoom, request.toRoom, request.toSlot, request.reason, ws.status, request.createdTime FROM ChangeRoomRequest request INNER JOIN WorkStatus ws ON request.statusID = ws.statusID WHERE request.studentID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", theStudent.studentID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }
    }
}
