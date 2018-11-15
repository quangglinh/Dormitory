namespace DormintoryStudentApp.UI
{
    partial class RoomExtra
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
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtElectricCost = new System.Windows.Forms.TextBox();
            this.txtWaterCost = new System.Windows.Forms.TextBox();
            this.txtExtraFee = new System.Windows.Forms.TextBox();
            this.txtExtraContent = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.completeFeeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentInfo.Location = new System.Drawing.Point(26, 21);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(228, 25);
            this.lblStudentInfo.TabIndex = 0;
            this.lblStudentInfo.Text = "NguyenLam, SE06118";
            this.lblStudentInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month";
            // 
            // cbbMonth
            // 
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(84, 75);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(128, 24);
            this.cbbMonth.TabIndex = 2;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // cbbYear
            // 
            this.cbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(312, 75);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(128, 24);
            this.cbbYear.TabIndex = 2;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Electric Cost (Đồng) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Water Cost (Đồng) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Extra Fee (Đồng) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Extra Content :";
            // 
            // txtElectricCost
            // 
            this.txtElectricCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricCost.Location = new System.Drawing.Point(181, 128);
            this.txtElectricCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtElectricCost.Name = "txtElectricCost";
            this.txtElectricCost.ReadOnly = true;
            this.txtElectricCost.Size = new System.Drawing.Size(197, 23);
            this.txtElectricCost.TabIndex = 4;
            // 
            // txtWaterCost
            // 
            this.txtWaterCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterCost.Location = new System.Drawing.Point(181, 168);
            this.txtWaterCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWaterCost.Name = "txtWaterCost";
            this.txtWaterCost.ReadOnly = true;
            this.txtWaterCost.Size = new System.Drawing.Size(197, 23);
            this.txtWaterCost.TabIndex = 4;
            // 
            // txtExtraFee
            // 
            this.txtExtraFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraFee.Location = new System.Drawing.Point(181, 206);
            this.txtExtraFee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExtraFee.Name = "txtExtraFee";
            this.txtExtraFee.ReadOnly = true;
            this.txtExtraFee.Size = new System.Drawing.Size(197, 23);
            this.txtExtraFee.TabIndex = 4;
            // 
            // txtExtraContent
            // 
            this.txtExtraContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraContent.Location = new System.Drawing.Point(181, 253);
            this.txtExtraContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExtraContent.Name = "txtExtraContent";
            this.txtExtraContent.ReadOnly = true;
            this.txtExtraContent.Size = new System.Drawing.Size(197, 93);
            this.txtExtraContent.TabIndex = 5;
            this.txtExtraContent.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // completeFeeLabel
            // 
            this.completeFeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completeFeeLabel.AutoSize = true;
            this.completeFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeFeeLabel.Location = new System.Drawing.Point(37, 380);
            this.completeFeeLabel.Name = "completeFeeLabel";
            this.completeFeeLabel.Size = new System.Drawing.Size(0, 22);
            this.completeFeeLabel.TabIndex = 7;
            this.completeFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 490);
            this.Controls.Add(this.completeFeeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtExtraContent);
            this.Controls.Add(this.txtExtraFee);
            this.Controls.Add(this.txtWaterCost);
            this.Controls.Add(this.txtElectricCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentInfo);
            this.Name = "RoomExtra";
            this.Text = "RoomExtra";
            this.Load += new System.EventHandler(this.RoomExtra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtElectricCost;
        private System.Windows.Forms.TextBox txtWaterCost;
        private System.Windows.Forms.TextBox txtExtraFee;
        private System.Windows.Forms.RichTextBox txtExtraContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label completeFeeLabel;
    }
}