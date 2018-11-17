namespace DormintoryStudentApp.UI
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toSlotCombobox = new System.Windows.Forms.ComboBox();
            this.toRoomCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sendButton.ForeColor = System.Drawing.Color.Ivory;
            this.sendButton.Location = new System.Drawing.Point(288, 323);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(98, 45);
            this.sendButton.TabIndex = 21;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // roomField
            // 
            this.roomField.Enabled = false;
            this.roomField.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomField.Location = new System.Drawing.Point(123, 118);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(149, 24);
            this.roomField.TabIndex = 20;
            // 
            // slotField
            // 
            this.slotField.Enabled = false;
            this.slotField.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotField.Location = new System.Drawing.Point(123, 88);
            this.slotField.Name = "slotField";
            this.slotField.Size = new System.Drawing.Size(149, 24);
            this.slotField.TabIndex = 19;
            // 
            // idField
            // 
            this.idField.Enabled = false;
            this.idField.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(123, 58);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(149, 24);
            this.idField.TabIndex = 18;
            // 
            // nameField
            // 
            this.nameField.Enabled = false;
            this.nameField.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(123, 28);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(149, 24);
            this.nameField.TabIndex = 17;
            // 
            // contentField
            // 
            this.contentField.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentField.Location = new System.Drawing.Point(123, 210);
            this.contentField.Multiline = true;
            this.contentField.Name = "contentField";
            this.contentField.Size = new System.Drawing.Size(263, 107);
            this.contentField.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(9, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reason (option)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(51, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "At Room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(45, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "From Slot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "StudentID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(51, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "At Room:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(63, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "To Slot:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(168, 246);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 22);
            this.messageLabel.TabIndex = 26;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.RoyalBlue;
            this.message.Location = new System.Drawing.Point(123, 210);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toRoomCombobox);
            this.groupBox1.Controls.Add(this.toSlotCombobox);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.messageLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.contentField);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.idField);
            this.groupBox1.Controls.Add(this.roomField);
            this.groupBox1.Controls.Add(this.slotField);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 378);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Room";
            // 
            // toSlotCombobox
            // 
            this.toSlotCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toSlotCombobox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSlotCombobox.FormattingEnabled = true;
            this.toSlotCombobox.Location = new System.Drawing.Point(122, 146);
            this.toSlotCombobox.Name = "toSlotCombobox";
            this.toSlotCombobox.Size = new System.Drawing.Size(121, 26);
            this.toSlotCombobox.TabIndex = 28;
            this.toSlotCombobox.SelectedIndexChanged += new System.EventHandler(this.toSlotCombobox_SelectedIndexChanged);
            // 
            // toRoomCombobox
            // 
            this.toRoomCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toRoomCombobox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRoomCombobox.FormattingEnabled = true;
            this.toRoomCombobox.Location = new System.Drawing.Point(122, 176);
            this.toRoomCombobox.Name = "toRoomCombobox";
            this.toRoomCombobox.Size = new System.Drawing.Size(121, 26);
            this.toRoomCombobox.TabIndex = 29;
            this.toRoomCombobox.SelectedIndexChanged += new System.EventHandler(this.toRoomCombobox_SelectedIndexChanged);
            this.toRoomCombobox.SelectedValueChanged += new System.EventHandler(this.toRoomCombobox_SelectedValueChanged);
            // 
            // ChangeRoomRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChangeRoomRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRoomRequestForm";
            this.Load += new System.EventHandler(this.ChangeRoomRequestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox toRoomCombobox;
        private System.Windows.Forms.ComboBox toSlotCombobox;
    }
}