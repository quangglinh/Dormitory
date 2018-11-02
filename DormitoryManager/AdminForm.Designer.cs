namespace DormitoryManager
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentRequests = new System.Windows.Forms.Button();
            this.UpdateRoom = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormitory Manager";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.StudentRequests);
            this.panel1.Controls.Add(this.UpdateRoom);
            this.panel1.Controls.Add(this.AddRoom);
            this.panel1.Location = new System.Drawing.Point(26, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 338);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Room\'s Informations";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentRequests
            // 
            this.StudentRequests.Location = new System.Drawing.Point(33, 108);
            this.StudentRequests.Name = "StudentRequests";
            this.StudentRequests.Size = new System.Drawing.Size(298, 23);
            this.StudentRequests.TabIndex = 3;
            this.StudentRequests.Text = "View Student\'s Requests";
            this.StudentRequests.UseVisualStyleBackColor = true;
            // 
            // UpdateRoom
            // 
            this.UpdateRoom.Location = new System.Drawing.Point(33, 64);
            this.UpdateRoom.Name = "UpdateRoom";
            this.UpdateRoom.Size = new System.Drawing.Size(298, 23);
            this.UpdateRoom.TabIndex = 2;
            this.UpdateRoom.Text = "Update a Room";
            this.UpdateRoom.UseVisualStyleBackColor = true;
            // 
            // AddRoom
            // 
            this.AddRoom.Location = new System.Drawing.Point(33, 21);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(298, 23);
            this.AddRoom.TabIndex = 0;
            this.AddRoom.Text = "Add New Room";
            this.AddRoom.UseVisualStyleBackColor = true;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(409, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 338);
            this.panel2.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UpdateRoom;
        private System.Windows.Forms.Button StudentRequests;
        private System.Windows.Forms.Button button1;
    }
}

