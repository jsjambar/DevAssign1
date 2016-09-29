namespace DatabaseManagementTool
{
    partial class AddPostalCodeControl
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
            this.PostalCodeSaveButton = new System.Windows.Forms.Button();
            this.PostalCodeValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PostalCodeSaveButton
            // 
            this.PostalCodeSaveButton.Location = new System.Drawing.Point(0, 83);
            this.PostalCodeSaveButton.Name = "PostalCodeSaveButton";
            this.PostalCodeSaveButton.Size = new System.Drawing.Size(75, 23);
            this.PostalCodeSaveButton.TabIndex = 0;
            this.PostalCodeSaveButton.Text = "Create";
            this.PostalCodeSaveButton.UseVisualStyleBackColor = true;
            this.PostalCodeSaveButton.Click += new System.EventHandler(this.PostalCodeSaveButton_Click);
            // 
            // PostalCodeValue
            // 
            this.PostalCodeValue.Location = new System.Drawing.Point(0, 47);
            this.PostalCodeValue.Name = "PostalCodeValue";
            this.PostalCodeValue.Size = new System.Drawing.Size(100, 20);
            this.PostalCodeValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create postalcodes";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(-3, 122);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(81, 13);
            this.FeedbackLabel.TabIndex = 3;
            this.FeedbackLabel.Text = "FeedbackLabel";
            // 
            // AddPostalCodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostalCodeValue);
            this.Controls.Add(this.PostalCodeSaveButton);
            this.Name = "AddPostalCodeControl";
            this.Size = new System.Drawing.Size(233, 182);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PostalCodeSaveButton;
        private System.Windows.Forms.TextBox PostalCodeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FeedbackLabel;
    }
}
