namespace Delmain_C969
{
    partial class UpdateCustomer
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
            this.postalTB = new System.Windows.Forms.TextBox();
            this.postalLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2TB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // postalTB
            // 
            this.postalTB.Location = new System.Drawing.Point(248, 365);
            this.postalTB.Name = "postalTB";
            this.postalTB.Size = new System.Drawing.Size(186, 29);
            this.postalTB.TabIndex = 25;
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Location = new System.Drawing.Point(87, 368);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(125, 25);
            this.postalLabel.TabIndex = 24;
            this.postalLabel.Text = "Postal Code:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(325, 477);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 42);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(124, 477);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(138, 42);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cityCB
            // 
            this.cityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(248, 297);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(279, 32);
            this.cityCB.TabIndex = 21;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(160, 300);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(52, 25);
            this.cityLabel.TabIndex = 20;
            this.cityLabel.Text = "City:";
            // 
            // address2TB
            // 
            this.address2TB.Location = new System.Drawing.Point(248, 229);
            this.address2TB.Name = "address2TB";
            this.address2TB.Size = new System.Drawing.Size(279, 29);
            this.address2TB.TabIndex = 19;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(248, 184);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(279, 29);
            this.addressTB.TabIndex = 18;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(121, 187);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(91, 25);
            this.addressLabel.TabIndex = 17;
            this.addressLabel.Text = "Address:";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(248, 115);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(186, 29);
            this.phoneTB.TabIndex = 16;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(63, 118);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(149, 25);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(248, 44);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(279, 29);
            this.nameTB.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(160, 25);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Customer Name:";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 562);
            this.Controls.Add(this.postalTB);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLabel);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postalTB;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address2TB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLabel;
    }
}