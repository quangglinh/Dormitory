namespace DormintoryStudentApp.UI
{
    partial class RoomStatus
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
            this.studentInfoLabel = new System.Windows.Forms.Label();
            this.roomStatusDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.roomStatusDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // studentInfoLabel
            // 
            this.studentInfoLabel.AutoSize = true;
            this.studentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.studentInfoLabel.Location = new System.Drawing.Point(26, 21);
            this.studentInfoLabel.Name = "studentInfoLabel";
            this.studentInfoLabel.Size = new System.Drawing.Size(228, 25);
            this.studentInfoLabel.TabIndex = 0;
            this.studentInfoLabel.Text = "NguyenLam, SE06118";
            this.studentInfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // roomStatusDGV
            // 
            this.roomStatusDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomStatusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomStatusDGV.Location = new System.Drawing.Point(29, 59);
            this.roomStatusDGV.Name = "roomStatusDGV";
            this.roomStatusDGV.Size = new System.Drawing.Size(655, 302);
            this.roomStatusDGV.TabIndex = 1;
            this.roomStatusDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStudentStatus_DataBindingComplete);
            // 
            // RoomStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 386);
            this.Controls.Add(this.roomStatusDGV);
            this.Controls.Add(this.studentInfoLabel);
            this.Name = "RoomStatus";
            this.Text = "RoomStatus";
            this.Load += new System.EventHandler(this.RoomStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomStatusDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentInfoLabel;
        private System.Windows.Forms.DataGridView roomStatusDGV;
    }
}