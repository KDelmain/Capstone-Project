namespace Delmain_C969
{
    partial class AddAppointment
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
            this.custIDLabel = new System.Windows.Forms.Label();
            this.custIDTB = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Location = new System.Drawing.Point(98, 47);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(127, 25);
            this.custIDLabel.TabIndex = 0;
            this.custIDLabel.Text = "Customer ID:";
            // 
            // custIDTB
            // 
            this.custIDTB.Location = new System.Drawing.Point(260, 44);
            this.custIDTB.Name = "custIDTB";
            this.custIDTB.Size = new System.Drawing.Size(107, 29);
            this.custIDTB.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(47, 114);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(178, 25);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Appointment Type:";
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(260, 111);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(249, 29);
            this.typeTB.TabIndex = 3;
            // 
            // startPicker
            // 
            this.startPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(260, 183);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(249, 29);
            this.startPicker.TabIndex = 4;
            // 
            // endPicker
            // 
            this.endPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(260, 252);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(249, 29);
            this.endPicker.TabIndex = 5;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(117, 187);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(108, 25);
            this.startLabel.TabIndex = 6;
            this.startLabel.Text = "Start Time:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(123, 256);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(102, 25);
            this.endLabel.TabIndex = 7;
            this.endLabel.Text = "End Time:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(110, 346);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 42);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(316, 346);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 42);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 422);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endPicker);
            this.Controls.Add(this.startPicker);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.custIDTB);
            this.Controls.Add(this.custIDLabel);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custIDLabel;
        private System.Windows.Forms.TextBox custIDTB;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
    }
}