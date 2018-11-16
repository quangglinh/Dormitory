namespace DormitoryManager
{
    partial class UpdateRoom
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbRoomId = new System.Windows.Forms.ComboBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.VND = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monthly fee";
            // 
            // cbRoomId
            // 
            this.cbRoomId.FormattingEnabled = true;
            this.cbRoomId.Location = new System.Drawing.Point(136, 86);
            this.cbRoomId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoomId.Name = "cbRoomId";
            this.cbRoomId.Size = new System.Drawing.Size(160, 24);
            this.cbRoomId.TabIndex = 3;
            this.cbRoomId.SelectedIndexChanged += new System.EventHandler(this.cbRoomId_SelectedIndexChanged);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(136, 147);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(160, 22);
            this.txtFee.TabIndex = 4;
            // 
            // VND
            // 
            this.VND.AutoSize = true;
            this.VND.Location = new System.Drawing.Point(318, 151);
            this.VND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VND.Name = "VND";
            this.VND.Size = new System.Drawing.Size(37, 17);
            this.VND.TabIndex = 5;
            this.VND.Text = "VND";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(28, 198);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(131, 47);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 47);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Update Fee";
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.VND);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.cbRoomId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateRoom";
            this.Text = "Update fee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRoomId;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label VND;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
    }
}