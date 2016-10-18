namespace DatabaseManagementTool
{
    partial class ViewAddressControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddressID = new System.Windows.Forms.TextBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressSaveButton = new System.Windows.Forms.Button();
            this.AddressStreet = new System.Windows.Forms.TextBox();
            this.AddressList = new System.Windows.Forms.ListBox();
            this.AddressNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddressID
            // 
            this.AddressID.Location = new System.Drawing.Point(213, 79);
            this.AddressID.Name = "AddressID";
            this.AddressID.ReadOnly = true;
            this.AddressID.Size = new System.Drawing.Size(100, 20);
            this.AddressID.TabIndex = 13;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(210, 220);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(97, 13);
            this.FeedbackLabel.TabIndex = 12;
            this.FeedbackLabel.Text = "Update an address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Click on an address to select";
            // 
            // AddressSaveButton
            // 
            this.AddressSaveButton.Location = new System.Drawing.Point(213, 176);
            this.AddressSaveButton.Name = "AddressSaveButton";
            this.AddressSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddressSaveButton.TabIndex = 10;
            this.AddressSaveButton.Text = "Save";
            this.AddressSaveButton.UseVisualStyleBackColor = true;
            this.AddressSaveButton.Click += new System.EventHandler(this.AddressSaveButton_Click);
            // 
            // AddressStreet
            // 
            this.AddressStreet.Location = new System.Drawing.Point(213, 115);
            this.AddressStreet.Name = "AddressStreet";
            this.AddressStreet.Size = new System.Drawing.Size(100, 20);
            this.AddressStreet.TabIndex = 9;
            // 
            // AddressList
            // 
            this.AddressList.FormattingEnabled = true;
            this.AddressList.Location = new System.Drawing.Point(70, 79);
            this.AddressList.Name = "AddressList";
            this.AddressList.Size = new System.Drawing.Size(120, 160);
            this.AddressList.TabIndex = 8;
            // 
            // AddressNumber
            // 
            this.AddressNumber.Location = new System.Drawing.Point(213, 141);
            this.AddressNumber.Name = "AddressNumber";
            this.AddressNumber.Size = new System.Drawing.Size(100, 20);
            this.AddressNumber.TabIndex = 14;
            // 
            // ViewAddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressNumber);
            this.Controls.Add(this.AddressID);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressSaveButton);
            this.Controls.Add(this.AddressStreet);
            this.Controls.Add(this.AddressList);
            this.Name = "ViewAddressControl";
            this.Size = new System.Drawing.Size(443, 306);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressID;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddressSaveButton;
        private System.Windows.Forms.TextBox AddressStreet;
        private System.Windows.Forms.ListBox AddressList;
        private System.Windows.Forms.TextBox AddressNumber;
    }
}
