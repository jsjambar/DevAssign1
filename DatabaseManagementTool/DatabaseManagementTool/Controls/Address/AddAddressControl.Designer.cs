namespace DatabaseManagementTool
{
    partial class AddAddressUserControl
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
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.AddressSaveButton = new System.Windows.Forms.Button();
            this.AddressNumber = new System.Windows.Forms.TextBox();
            this.AddCountryControlTitle = new System.Windows.Forms.Label();
            this.AddressStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(42, 194);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.FeedbackLabel.TabIndex = 7;
            // 
            // AddressSaveButton
            // 
            this.AddressSaveButton.Location = new System.Drawing.Point(86, 146);
            this.AddressSaveButton.Name = "AddressSaveButton";
            this.AddressSaveButton.Size = new System.Drawing.Size(100, 23);
            this.AddressSaveButton.TabIndex = 6;
            this.AddressSaveButton.Text = "Save address";
            this.AddressSaveButton.UseVisualStyleBackColor = true;
            this.AddressSaveButton.Click += new System.EventHandler(this.AddressSaveButton_Click);
            // 
            // AddressNumber
            // 
            this.AddressNumber.Location = new System.Drawing.Point(86, 120);
            this.AddressNumber.Name = "AddressNumber";
            this.AddressNumber.Size = new System.Drawing.Size(100, 20);
            this.AddressNumber.TabIndex = 5;
            // 
            // AddCountryControlTitle
            // 
            this.AddCountryControlTitle.AutoSize = true;
            this.AddCountryControlTitle.Location = new System.Drawing.Point(42, 58);
            this.AddCountryControlTitle.Name = "AddCountryControlTitle";
            this.AddCountryControlTitle.Size = new System.Drawing.Size(89, 13);
            this.AddCountryControlTitle.TabIndex = 4;
            this.AddCountryControlTitle.Text = "Add new address";
            // 
            // AddressStreet
            // 
            this.AddressStreet.Location = new System.Drawing.Point(86, 94);
            this.AddressStreet.Name = "AddressStreet";
            this.AddressStreet.Size = new System.Drawing.Size(100, 20);
            this.AddressStreet.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Street name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number";
            // 
            // AddAddressUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressStreet);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.AddressSaveButton);
            this.Controls.Add(this.AddressNumber);
            this.Controls.Add(this.AddCountryControlTitle);
            this.Name = "AddAddressUserControl";
            this.Size = new System.Drawing.Size(452, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Button AddressSaveButton;
        private System.Windows.Forms.TextBox AddressNumber;
        private System.Windows.Forms.Label AddCountryControlTitle;
        private System.Windows.Forms.TextBox AddressStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
