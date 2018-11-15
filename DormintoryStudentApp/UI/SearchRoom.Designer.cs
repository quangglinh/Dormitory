namespace DormintoryStudentApp.UI
{
    partial class SearchRoom
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
            this.domComboBox = new System.Windows.Forms.ComboBox();
            this.capacityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchResultDGV = new System.Windows.Forms.DataGridView();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dom:";
            // 
            // domComboBox
            // 
            this.domComboBox.FormattingEnabled = true;
            this.domComboBox.Location = new System.Drawing.Point(52, 43);
            this.domComboBox.Name = "domComboBox";
            this.domComboBox.Size = new System.Drawing.Size(60, 21);
            this.domComboBox.TabIndex = 1;
            // 
            // capacityComboBox
            // 
            this.capacityComboBox.FormattingEnabled = true;
            this.capacityComboBox.Location = new System.Drawing.Point(213, 45);
            this.capacityComboBox.Name = "capacityComboBox";
            this.capacityComboBox.Size = new System.Drawing.Size(60, 21);
            this.capacityComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacity:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(291, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 27);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search ";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(382, 32);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(146, 65);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Show all available ";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchResultDGV
            // 
            this.searchResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDGV.Location = new System.Drawing.Point(16, 145);
            this.searchResultDGV.Name = "searchResultDGV";
            this.searchResultDGV.Size = new System.Drawing.Size(670, 237);
            this.searchResultDGV.TabIndex = 6;
            this.searchResultDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.searchResultDGV_DataBindingComplete);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(118, 78);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(155, 20);
            this.inputText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter room name:";
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(291, 72);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(75, 26);
            this.searchByNameButton.TabIndex = 9;
            this.searchByNameButton.Text = "Search";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.messageLabel.Location = new System.Drawing.Point(230, 115);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(56, 13);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search Available Room: ";
            // 
            // SearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.searchResultDGV);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capacityComboBox);
            this.Controls.Add(this.domComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchRoom";
            this.Text = "SearchRoom";
            this.Load += new System.EventHandler(this.SearchRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox domComboBox;
        private System.Windows.Forms.ComboBox capacityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.DataGridView searchResultDGV;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label4;
    }
}