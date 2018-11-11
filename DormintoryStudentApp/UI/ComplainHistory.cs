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
    public partial class ComplainHistory : Form
    {
        Student theStudent;
        public ComplainHistory()
        {
            InitializeComponent();
        }
        public ComplainHistory(Student theStudent)
        {
            InitializeComponent();
            this.theStudent = theStudent;
        }

        private void ComplainHistory_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT pc.studentID, pc.fromSlot, pc.atRoom, pc.reason, ws.status, pc.createdTime FROM ProblemComplain pc INNER JOIN WorkStatus ws ON pc.statusID = ws.statusID WHERE pc.studentID=@id";
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
