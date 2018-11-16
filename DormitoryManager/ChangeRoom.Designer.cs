namespace DormitoryManager {
    partial class ChangeRoom {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtMaxSlot = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtDom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSlot = new System.Windows.Forms.ComboBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFromSlot = new System.Windows.Forms.TextBox();
            this.txtFromRoom = new System.Windows.Forms.TextBox();
            this.txtFromMaxSlot = new System.Windows.Forms.TextBox();
            this.txtFromFee = new System.Windows.Forms.TextBox();
            this.txtFromDom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbRoom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.lbAvailable);
            this.groupBox1.Controls.Add(this.txtStudentPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStudentMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(133, 27);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(245, 22);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // lbAvailable
            // 
            this.lbAvailable.AutoSize = true;
            this.lbAvailable.ForeColor = System.Drawing.Color.Red;
            this.lbAvailable.Location = new System.Drawing.Point(130, 57);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(91, 17);
            this.lbAvailable.TabIndex = 1;
            this.lbAvailable.Text = "Not Available";
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(133, 143);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.ReadOnly = true;
            this.txtStudentPhone.Size = new System.Drawing.Size(245, 22);
            this.txtStudentPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Phone";
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.Location = new System.Drawing.Point(133, 114);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.ReadOnly = true;
            this.txtStudentMail.Size = new System.Drawing.Size(245, 22);
            this.txtStudentMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Mail";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(133, 84);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(245, 22);
            this.txtStudentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID";
            // 
            // gbRoom
            // 
            this.gbRoom.Controls.Add(this.btnChange);
            this.gbRoom.Controls.Add(this.txtMaxSlot);
            this.gbRoom.Controls.Add(this.txtFee);
            this.gbRoom.Controls.Add(this.txtDom);
            this.gbRoom.Controls.Add(this.label9);
            this.gbRoom.Controls.Add(this.label8);
            this.gbRoom.Controls.Add(this.label7);
            this.gbRoom.Controls.Add(this.cbSlot);
            this.gbRoom.Controls.Add(this.cbRoom);
            this.gbRoom.Controls.Add(this.label5);
            this.gbRoom.Controls.Add(this.label6);
            this.gbRoom.Location = new System.Drawing.Point(654, 12);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(330, 186);
            this.gbRoom.TabIndex = 1;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "To";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(242, 27);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(80, 54);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtMaxSlot
            // 
            this.txtMaxSlot.Enabled = false;
            this.txtMaxSlot.Location = new System.Drawing.Point(109, 143);
            this.txtMaxSlot.Name = "txtMaxSlot";
            this.txtMaxSlot.Size = new System.Drawing.Size(121, 22);
            this.txtMaxSlot.TabIndex = 10;
            // 
            // txtFee
            // 
            this.txtFee.Enabled = false;
            this.txtFee.Location = new System.Drawing.Point(109, 114);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(121, 22);
            this.txtFee.TabIndex = 9;
            // 
            // txtDom
            // 
            this.txtDom.Enabled = false;
            this.txtDom.Location = new System.Drawing.Point(109, 84);
            this.txtDom.Name = "txtDom";
            this.txtDom.Size = new System.Drawing.Size(121, 22);
            this.txtDom.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Max Slot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fee/Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dom";
            // 
            // cbSlot
            // 
            this.cbSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot.FormattingEnabled = true;
            this.cbSlot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSlot.Location = new System.Drawing.Point(109, 54);
            this.cbSlot.Name = "cbSlot";
            this.cbSlot.Size = new System.Drawing.Size(121, 24);
            this.cbSlot.TabIndex = 4;
            // 
            // cbRoom
            // 
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(109, 27);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 24);
            this.cbRoom.TabIndex = 3;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            this.cbRoom.TextUpdate += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Slot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Room Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFromSlot);
            this.groupBox2.Controls.Add(this.txtFromRoom);
            this.groupBox2.Controls.Add(this.txtFromMaxSlot);
            this.groupBox2.Controls.Add(this.txtFromFee);
            this.groupBox2.Controls.Add(this.txtFromDom);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(407, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 186);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // txtFromSlot
            // 
            this.txtFromSlot.Location = new System.Drawing.Point(109, 54);
            this.txtFromSlot.Name = "txtFromSlot";
            this.txtFromSlot.ReadOnly = true;
            this.txtFromSlot.Size = new System.Drawing.Size(121, 22);
            this.txtFromSlot.TabIndex = 12;
            // 
            // txtFromRoom
            // 
            this.txtFromRoom.Location = new System.Drawing.Point(109, 27);
            this.txtFromRoom.Name = "txtFromRoom";
            this.txtFromRoom.ReadOnly = true;
            this.txtFromRoom.Size = new System.Drawing.Size(121, 22);
            this.txtFromRoom.TabIndex = 11;
            // 
            // txtFromMaxSlot
            // 
            this.txtFromMaxSlot.Location = new System.Drawing.Point(109, 143);
            this.txtFromMaxSlot.Name = "txtFromMaxSlot";
            this.txtFromMaxSlot.ReadOnly = true;
            this.txtFromMaxSlot.Size = new System.Drawing.Size(121, 22);
            this.txtFromMaxSlot.TabIndex = 10;
            // 
            // txtFromFee
            // 
            this.txtFromFee.Location = new System.Drawing.Point(109, 114);
            this.txtFromFee.Name = "txtFromFee";
            this.txtFromFee.ReadOnly = true;
            this.txtFromFee.Size = new System.Drawing.Size(121, 22);
            this.txtFromFee.TabIndex = 9;
            // 
            // txtFromDom
            // 
            this.txtFromDom.Location = new System.Drawing.Point(109, 84);
            this.txtFromDom.Name = "txtFromDom";
            this.txtFromDom.ReadOnly = true;
            this.txtFromDom.Size = new System.Drawing.Size(121, 22);
            this.txtFromDom.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Max Slot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Fee/Month";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Dom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Slot";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Room Name";
            // 
            // ChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 202);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRoom);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeRoom";
            this.Text = "Change Room";
            this.Load += new System.EventHandler(this.StudentCheckin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.ComboBox cbSlot;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtMaxSlot;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtDom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFromSlot;
        private System.Windows.Forms.TextBox txtFromRoom;
        private System.Windows.Forms.TextBox txtFromMaxSlot;
        private System.Windows.Forms.TextBox txtFromFee;
        private System.Windows.Forms.TextBox txtFromDom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}