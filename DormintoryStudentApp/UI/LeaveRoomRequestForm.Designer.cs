namespace DormintoryStudentApp.UI
{
    partial class LeaveRoomRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slotField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.roomField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // slotField
            // 
            this.slotField.Enabled = false;
            this.slotField.Location = new System.Drawing.Point(105, 118);
            this.slotField.Name = "slotField";
            this.slotField.Size = new System.Drawing.Size(149, 20);
            this.slotField.TabIndex = 25;
            // 
            // idField
            // 
            this.idField.Enabled = false;
            this.idField.Location = new System.Drawing.Point(104, 83);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(149, 20);
            this.idField.TabIndex = 24;
            // 
            // nameField
            // 
            this.nameField.Enabled = false;
            this.nameField.Location = new System.Drawing.Point(105, 47);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(149, 20);
            this.nameField.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "From Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "StudentID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(116, 208);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(98, 45);
            this.sendButton.TabIndex = 29;
            this.sendButton.Text = "Leave";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // roomField
            // 
            this.roomField.Enabled = false;
            this.roomField.Location = new System.Drawing.Point(104, 152);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(149, 20);
            this.roomField.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "At Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(90, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Your Information";
            // 
            // LeaveRoomRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.slotField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LeaveRoomRequestForm";
            this.Text = "LeaveRoomRequestForm";
            this.Load += new System.EventHandler(this.LeaveRoomRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slotField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox roomField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}