namespace DormintoryStudentApp.UI
{
    partial class ComplainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contentField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.slotField = new System.Windows.Forms.TextBox();
            this.roomField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "StudentID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From Slot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "At Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Content";
            // 
            // contentField
            // 
            this.contentField.Location = new System.Drawing.Point(88, 174);
            this.contentField.Multiline = true;
            this.contentField.Name = "contentField";
            this.contentField.Size = new System.Drawing.Size(263, 203);
            this.contentField.TabIndex = 5;
            // 
            // nameField
            // 
            this.nameField.Enabled = false;
            this.nameField.Location = new System.Drawing.Point(89, 38);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(149, 20);
            this.nameField.TabIndex = 6;
            // 
            // idField
            // 
            this.idField.Enabled = false;
            this.idField.Location = new System.Drawing.Point(88, 74);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(149, 20);
            this.idField.TabIndex = 7;
            // 
            // slotField
            // 
            this.slotField.Enabled = false;
            this.slotField.Location = new System.Drawing.Point(89, 109);
            this.slotField.Name = "slotField";
            this.slotField.Size = new System.Drawing.Size(149, 20);
            this.slotField.TabIndex = 8;
            // 
            // roomField
            // 
            this.roomField.Enabled = false;
            this.roomField.Location = new System.Drawing.Point(89, 145);
            this.roomField.Name = "roomField";
            this.roomField.Size = new System.Drawing.Size(149, 20);
            this.roomField.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 460);
            this.Controls.Add(this.button1);
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
            this.Name = "ComplainForm";
            this.Text = "ComplainForm";
            this.Load += new System.EventHandler(this.ComplainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contentField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox slotField;
        private System.Windows.Forms.TextBox roomField;
        private System.Windows.Forms.Button button1;
    }
}