namespace DormitoryManager {
    partial class StudentCheckout {
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtMaxSlot = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtDom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbRoom.SuspendLayout();
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
            this.gbRoom.Controls.Add(this.btnCheckout);
            this.gbRoom.Controls.Add(this.txtSlot);
            this.gbRoom.Controls.Add(this.txtRoom);
            this.gbRoom.Controls.Add(this.txtMaxSlot);
            this.gbRoom.Controls.Add(this.txtFee);
            this.gbRoom.Controls.Add(this.txtDom);
            this.gbRoom.Controls.Add(this.label9);
            this.gbRoom.Controls.Add(this.label8);
            this.gbRoom.Controls.Add(this.label7);
            this.gbRoom.Controls.Add(this.label5);
            this.gbRoom.Controls.Add(this.label6);
            this.gbRoom.Location = new System.Drawing.Point(407, 12);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(317, 186);
            this.gbRoom.TabIndex = 1;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "Room";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(237, 27);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 49);
            this.btnCheckout.TabIndex = 13;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(109, 54);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.ReadOnly = true;
            this.txtSlot.Size = new System.Drawing.Size(121, 22);
            this.txtSlot.TabIndex = 12;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(109, 27);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(121, 22);
            this.txtRoom.TabIndex = 11;
            // 
            // txtMaxSlot
            // 
            this.txtMaxSlot.Location = new System.Drawing.Point(109, 143);
            this.txtMaxSlot.Name = "txtMaxSlot";
            this.txtMaxSlot.ReadOnly = true;
            this.txtMaxSlot.Size = new System.Drawing.Size(121, 22);
            this.txtMaxSlot.TabIndex = 10;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(109, 114);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(121, 22);
            this.txtFee.TabIndex = 9;
            // 
            // txtDom
            // 
            this.txtDom.Location = new System.Drawing.Point(109, 84);
            this.txtDom.Name = "txtDom";
            this.txtDom.ReadOnly = true;
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
            // StudentCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 202);
            this.Controls.Add(this.gbRoom);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentCheckout";
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.StudentCheckin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxSlot;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtDom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnCheckout;
    }
}