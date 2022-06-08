namespace Delmain_C969
{
    partial class Main
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
            this.calendarLabel = new System.Windows.Forms.Label();
            this.weekAppsRB = new System.Windows.Forms.RadioButton();
            this.monthAppsRB = new System.Windows.Forms.RadioButton();
            this.calendarDGV = new System.Windows.Forms.DataGridView();
            this.addAppButton = new System.Windows.Forms.Button();
            this.updateAppButton = new System.Windows.Forms.Button();
            this.deleteAppButton = new System.Windows.Forms.Button();
            this.custRecordsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(62, 66);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(237, 25);
            this.calendarLabel.TabIndex = 0;
            this.calendarLabel.Text = "Scheduled Appointments:";
            // 
            // weekAppsRB
            // 
            this.weekAppsRB.AutoSize = true;
            this.weekAppsRB.Location = new System.Drawing.Point(334, 64);
            this.weekAppsRB.Name = "weekAppsRB";
            this.weekAppsRB.Size = new System.Drawing.Size(132, 29);
            this.weekAppsRB.TabIndex = 1;
            this.weekAppsRB.TabStop = true;
            this.weekAppsRB.Text = "This Week";
            this.weekAppsRB.UseVisualStyleBackColor = true;
            this.weekAppsRB.CheckedChanged += new System.EventHandler(this.weekAppsRB_CheckedChanged);
            // 
            // monthAppsRB
            // 
            this.monthAppsRB.AutoSize = true;
            this.monthAppsRB.Location = new System.Drawing.Point(496, 64);
            this.monthAppsRB.Name = "monthAppsRB";
            this.monthAppsRB.Size = new System.Drawing.Size(135, 29);
            this.monthAppsRB.TabIndex = 2;
            this.monthAppsRB.TabStop = true;
            this.monthAppsRB.Text = "This Month";
            this.monthAppsRB.UseVisualStyleBackColor = true;
            this.monthAppsRB.CheckedChanged += new System.EventHandler(this.monthAppsRB_CheckedChanged);
            // 
            // calendarDGV
            // 
            this.calendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDGV.Location = new System.Drawing.Point(67, 124);
            this.calendarDGV.Name = "calendarDGV";
            this.calendarDGV.RowHeadersWidth = 72;
            this.calendarDGV.RowTemplate.Height = 31;
            this.calendarDGV.Size = new System.Drawing.Size(1219, 750);
            this.calendarDGV.TabIndex = 3;
            this.calendarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarDGV_CellClick);
            // 
            // addAppButton
            // 
            this.addAppButton.Location = new System.Drawing.Point(807, 908);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(138, 42);
            this.addAppButton.TabIndex = 4;
            this.addAppButton.Text = "Add";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addAppButton_Click);
            // 
            // updateAppButton
            // 
            this.updateAppButton.Location = new System.Drawing.Point(978, 908);
            this.updateAppButton.Name = "updateAppButton";
            this.updateAppButton.Size = new System.Drawing.Size(138, 42);
            this.updateAppButton.TabIndex = 5;
            this.updateAppButton.Text = "Update";
            this.updateAppButton.UseVisualStyleBackColor = true;
            this.updateAppButton.Click += new System.EventHandler(this.updateAppButton_Click);
            // 
            // deleteAppButton
            // 
            this.deleteAppButton.Location = new System.Drawing.Point(1148, 908);
            this.deleteAppButton.Name = "deleteAppButton";
            this.deleteAppButton.Size = new System.Drawing.Size(138, 42);
            this.deleteAppButton.TabIndex = 6;
            this.deleteAppButton.Text = "Delete";
            this.deleteAppButton.UseVisualStyleBackColor = true;
            this.deleteAppButton.Click += new System.EventHandler(this.deleteAppButton_Click);
            // 
            // custRecordsButton
            // 
            this.custRecordsButton.Location = new System.Drawing.Point(1428, 383);
            this.custRecordsButton.Name = "custRecordsButton";
            this.custRecordsButton.Size = new System.Drawing.Size(203, 42);
            this.custRecordsButton.TabIndex = 7;
            this.custRecordsButton.Text = "Customer Records";
            this.custRecordsButton.UseVisualStyleBackColor = true;
            this.custRecordsButton.Click += new System.EventHandler(this.custRecordsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(1428, 570);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(203, 42);
            this.reportsButton.TabIndex = 8;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1567, 1006);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(138, 42);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 1085);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.custRecordsButton);
            this.Controls.Add(this.deleteAppButton);
            this.Controls.Add(this.updateAppButton);
            this.Controls.Add(this.addAppButton);
            this.Controls.Add(this.calendarDGV);
            this.Controls.Add(this.monthAppsRB);
            this.Controls.Add(this.weekAppsRB);
            this.Controls.Add(this.calendarLabel);
            this.Name = "Main";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.RadioButton weekAppsRB;
        private System.Windows.Forms.RadioButton monthAppsRB;
        private System.Windows.Forms.DataGridView calendarDGV;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.Button updateAppButton;
        private System.Windows.Forms.Button deleteAppButton;
        private System.Windows.Forms.Button custRecordsButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button logoutButton;
    }
}