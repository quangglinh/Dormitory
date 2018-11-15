namespace DormintoryStudentApp.UI
{
    partial class ChangePasswordForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.newPassField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.currentPassField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(119, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "name";
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.Location = new System.Drawing.Point(122, 197);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(131, 43);
            this.saveChangeButton.TabIndex = 3;
            this.saveChangeButton.Text = "Save Change";
            this.saveChangeButton.UseVisualStyleBackColor = true;
            this.saveChangeButton.Click += new System.EventHandler(this.saveChangeButton_Click);
            // 
            // confirmPassField
            // 
            this.confirmPassField.Location = new System.Drawing.Point(119, 127);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(168, 20);
            this.confirmPassField.TabIndex = 6;
            this.confirmPassField.UseSystemPasswordChar = true;
            // 
            // newPassField
            // 
            this.newPassField.Location = new System.Drawing.Point(119, 96);
            this.newPassField.Name = "newPassField";
            this.newPassField.Size = new System.Drawing.Size(168, 20);
            this.newPassField.TabIndex = 7;
            this.newPassField.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirm new pass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "New pass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(113, 167);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 13;
            // 
            // currentPassField
            // 
            this.currentPassField.Location = new System.Drawing.Point(119, 70);
            this.currentPassField.Name = "currentPassField";
            this.currentPassField.Size = new System.Drawing.Size(168, 20);
            this.currentPassField.TabIndex = 5;
            this.currentPassField.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current pass:";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 274);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassField);
            this.Controls.Add(this.confirmPassField);
            this.Controls.Add(this.currentPassField);
            this.Controls.Add(this.saveChangeButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveChangeButton;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.TextBox newPassField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox currentPassField;
        private System.Windows.Forms.Label label1;
    }
}