namespace Delmain_C969
{
    partial class CustomerRecords
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
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.addCustButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.Location = new System.Drawing.Point(46, 152);
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersWidth = 72;
            this.customersDGV.RowTemplate.Height = 31;
            this.customersDGV.Size = new System.Drawing.Size(1397, 524);
            this.customersDGV.TabIndex = 0;
            this.customersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDGV_CellClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1305, 805);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 42);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.Location = new System.Drawing.Point(1305, 710);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(138, 42);
            this.deleteCustButton.TabIndex = 19;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = true;
            this.deleteCustButton.Click += new System.EventHandler(this.deleteCustButton_Click);
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(1124, 710);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(138, 42);
            this.updateCustButton.TabIndex = 18;
            this.updateCustButton.Text = "Update";
            this.updateCustButton.UseVisualStyleBackColor = true;
            this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
            // 
            // addCustButton
            // 
            this.addCustButton.Location = new System.Drawing.Point(940, 710);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(138, 42);
            this.addCustButton.TabIndex = 17;
            this.addCustButton.Text = "Add";
            this.addCustButton.UseVisualStyleBackColor = true;
            this.addCustButton.Click += new System.EventHandler(this.addCustButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(773, 86);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(246, 25);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "Search by customer name:";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(1035, 83);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(227, 29);
            this.searchTB.TabIndex = 22;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1305, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 42);
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 880);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteCustButton);
            this.Controls.Add(this.updateCustButton);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.customersDGV);
            this.Name = "CustomerRecords";
            this.Text = "Customer Records";
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchButton;
    }
}