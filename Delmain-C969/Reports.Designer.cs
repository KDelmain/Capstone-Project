namespace Delmain_C969
{
    partial class Reports
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
            this.appTypeRB = new System.Windows.Forms.RadioButton();
            this.appsPerDayRB = new System.Windows.Forms.RadioButton();
            this.schedulesRB = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            this.reportDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appTypeRB
            // 
            this.appTypeRB.AutoSize = true;
            this.appTypeRB.Location = new System.Drawing.Point(100, 183);
            this.appTypeRB.Name = "appTypeRB";
            this.appTypeRB.Size = new System.Drawing.Size(395, 29);
            this.appTypeRB.TabIndex = 14;
            this.appTypeRB.TabStop = true;
            this.appTypeRB.Text = "Number of Appointment Types per Month";
            this.appTypeRB.UseVisualStyleBackColor = true;
            this.appTypeRB.CheckedChanged += new System.EventHandler(this.appTypeRB_CheckedChanged);
            // 
            // appsPerDayRB
            // 
            this.appsPerDayRB.AutoSize = true;
            this.appsPerDayRB.Location = new System.Drawing.Point(100, 139);
            this.appsPerDayRB.Name = "appsPerDayRB";
            this.appsPerDayRB.Size = new System.Drawing.Size(325, 29);
            this.appsPerDayRB.TabIndex = 13;
            this.appsPerDayRB.TabStop = true;
            this.appsPerDayRB.Text = "Number of Appointments per Day";
            this.appsPerDayRB.UseVisualStyleBackColor = true;
            this.appsPerDayRB.CheckedChanged += new System.EventHandler(this.appsPerDayRB_CheckedChanged);
            // 
            // schedulesRB
            // 
            this.schedulesRB.AutoSize = true;
            this.schedulesRB.Location = new System.Drawing.Point(100, 93);
            this.schedulesRB.Name = "schedulesRB";
            this.schedulesRB.Size = new System.Drawing.Size(196, 29);
            this.schedulesRB.TabIndex = 12;
            this.schedulesRB.TabStop = true;
            this.schedulesRB.Text = "Realtor Schedules";
            this.schedulesRB.UseVisualStyleBackColor = true;
            this.schedulesRB.CheckedChanged += new System.EventHandler(this.schedulesRB_CheckedChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(690, 943);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 42);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(47, 44);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(340, 25);
            this.formLabel.TabIndex = 10;
            this.formLabel.Text = "Select what type of report to generate:";
            // 
            // reportDGV
            // 
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Location = new System.Drawing.Point(52, 280);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.RowHeadersWidth = 72;
            this.reportDGV.RowTemplate.Height = 31;
            this.reportDGV.Size = new System.Drawing.Size(776, 591);
            this.reportDGV.TabIndex = 9;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 1022);
            this.Controls.Add(this.appTypeRB);
            this.Controls.Add(this.appsPerDayRB);
            this.Controls.Add(this.schedulesRB);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.reportDGV);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton appTypeRB;
        private System.Windows.Forms.RadioButton appsPerDayRB;
        private System.Windows.Forms.RadioButton schedulesRB;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridView reportDGV;
    }
}