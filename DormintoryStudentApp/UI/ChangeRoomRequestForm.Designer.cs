﻿namespace DormintoryStudentApp.UI
{
    partial class ChangeRoomRequestForm
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
            this.sendButton = new System.Windows.Forms.Button();
            this.roomField = new System.Windows.Forms.TextBox();
            this.slotField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.contentField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toRoomField = new System.Windows.Forms.TextBox();
            this.toSlotField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(339, 449);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(131, 55);
            this.sendButton.TabIndex = 21;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // roomField
            // 
            this.roomField.Enabled = false;
            this.roomField.Location = new System.Drawing.Point(120, 154);
            this.roomField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(197, 22);
            this.roomField.TabIndex = 20;
            // 
            // slotField
            // 
            this.slotField.Enabled = false;
            this.slotField.Location = new System.Drawing.Point(120, 110);
            this.slotField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slotField.Name = "slotField";
            this.slotField.Size = new System.Drawing.Size(197, 22);
            this.slotField.TabIndex = 19;
            // 
            // idField
            // 
            this.idField.Enabled = false;
            this.idField.Location = new System.Drawing.Point(119, 66);
            this.idField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(197, 22);
            this.idField.TabIndex = 18;
            // 
            // nameField
            // 
            this.nameField.Enabled = false;
            this.nameField.Location = new System.Drawing.Point(120, 22);
            this.nameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(197, 22);
            this.nameField.TabIndex = 17;
            // 
            // contentField
            // 
            this.contentField.Location = new System.Drawing.Point(123, 283);
            this.contentField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentField.Multiline = true;
            this.contentField.Name = "contentField";
            this.contentField.Size = new System.Drawing.Size(349, 131);
            this.contentField.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reason (option)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "At Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "From Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "StudentID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student:";
            // 
            // toRoomField
            // 
            this.toRoomField.Location = new System.Drawing.Point(120, 231);
            this.toRoomField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toRoomField.Name = "toRoomField";
            this.toRoomField.Size = new System.Drawing.Size(197, 22);
            this.toRoomField.TabIndex = 25;
            // 
            // toSlotField
            // 
            this.toSlotField.Location = new System.Drawing.Point(120, 187);
            this.toSlotField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toSlotField.Name = "toSlotField";
            this.toSlotField.Size = new System.Drawing.Size(197, 22);
            this.toSlotField.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "To Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "To Slot";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(196, 283);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 26;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.RoyalBlue;
            this.message.Location = new System.Drawing.Point(352, 239);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 17);
            this.message.TabIndex = 27;
            // 
            // ChangeRoomRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 533);
            this.Controls.Add(this.message);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.toRoomField);
            this.Controls.Add(this.toSlotField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.roomField);
            this.Controls.Add(this.slotField);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.contentField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeRoomRequestForm";
            this.Text = "ChangeRoomRequestForm";
            this.Load += new System.EventHandler(this.ChangeRoomRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox roomField;
        private System.Windows.Forms.TextBox slotField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox contentField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toRoomField;
        private System.Windows.Forms.TextBox toSlotField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label message;
    }
}