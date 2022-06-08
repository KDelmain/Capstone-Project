namespace Delmain_C969
{
    partial class UpdateAppointment
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
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.custIDTB = new System.Windows.Forms.TextBox();
            this.custIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(324, 341);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 42);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(118, 341);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(138, 42);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(133, 247);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(102, 25);
            this.endLabel.TabIndex = 17;
            this.endLabel.Text = "End Time:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(127, 179);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(108, 25);
            this.startLabel.TabIndex = 16;
            this.startLabel.Text = "Start Time:";
            // 
            // endPicker
            // 
            this.endPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(270, 243);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(249, 29);
            this.endPicker.TabIndex = 15;
            // 
            // startPicker
            // 
            this.startPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(270, 175);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(249, 29);
            this.startPicker.TabIndex = 14;
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(270, 104);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(249, 29);
            this.typeTB.TabIndex = 13;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(57, 107);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(178, 25);
            this.typeLabel.TabIndex = 12;
            this.typeLabel.Text = "Appointment Type:";
            // 
            // custIDTB
            // 
            this.custIDTB.Location = new System.Drawing.Point(270, 37);
            this.custIDTB.Name = "custIDTB";
            this.custIDTB.Size = new System.Drawing.Size(107, 29);
            this.custIDTB.TabIndex = 11;
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Location = new System.Drawing.Point(108, 40);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(127, 25);
            this.custIDLabel.TabIndex = 10;
            this.custIDLabel.Text = "Customer ID:";
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 423);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endPicker);
            this.Controls.Add(this.startPicker);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.custIDTB);
            this.Controls.Add(this.custIDLabel);
            this.Name = "UpdateAppointment";
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox custIDTB;
        private System.Windows.Forms.Label custIDLabel;
    }
}