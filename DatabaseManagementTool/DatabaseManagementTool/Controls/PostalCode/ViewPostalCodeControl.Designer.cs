namespace DatabaseManagementTool
{
    partial class ViewPostalCodeControl
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
            this.PostalCodeID = new System.Windows.Forms.TextBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PostalCodeSaveButton = new System.Windows.Forms.Button();
            this.PostalCodeName = new System.Windows.Forms.TextBox();
            this.PostalCodeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PostalCodeID
            // 
            this.PostalCodeID.Location = new System.Drawing.Point(180, 66);
            this.PostalCodeID.Name = "PostalCodeID";
            this.PostalCodeID.ReadOnly = true;
            this.PostalCodeID.Size = new System.Drawing.Size(100, 20);
            this.PostalCodeID.TabIndex = 13;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(177, 177);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(109, 13);
            this.FeedbackLabel.TabIndex = 12;
            this.FeedbackLabel.Text = "Update a postal code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Click on a postal code to select";
            // 
            // PostalCodeSaveButton
            // 
            this.PostalCodeSaveButton.Location = new System.Drawing.Point(180, 138);
            this.PostalCodeSaveButton.Name = "PostalCodeSaveButton";
            this.PostalCodeSaveButton.Size = new System.Drawing.Size(75, 31);
            this.PostalCodeSaveButton.TabIndex = 10;
            this.PostalCodeSaveButton.Text = "Save";
            this.PostalCodeSaveButton.UseVisualStyleBackColor = true;
            this.PostalCodeSaveButton.Click += new System.EventHandler(this.PostalCodeSaveButton_Click);
            // 
            // PostalCodeName
            // 
            this.PostalCodeName.Location = new System.Drawing.Point(180, 102);
            this.PostalCodeName.Name = "PostalCodeName";
            this.PostalCodeName.Size = new System.Drawing.Size(100, 20);
            this.PostalCodeName.TabIndex = 9;
            // 
            // PostalCodeList
            // 
            this.PostalCodeList.FormattingEnabled = true;
            this.PostalCodeList.Location = new System.Drawing.Point(37, 66);
            this.PostalCodeList.Name = "PostalCodeList";
            this.PostalCodeList.Size = new System.Drawing.Size(120, 134);
            this.PostalCodeList.TabIndex = 8;
            this.PostalCodeList.SelectedIndexChanged += new System.EventHandler(this.PostalCodeList_SelectedIndexChanged);
            // 
            // ViewPostalCodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PostalCodeID);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostalCodeSaveButton);
            this.Controls.Add(this.PostalCodeName);
            this.Controls.Add(this.PostalCodeList);
            this.Name = "ViewPostalCodeControl";
            this.Size = new System.Drawing.Size(554, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PostalCodeID;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PostalCodeSaveButton;
        private System.Windows.Forms.TextBox PostalCodeName;
        private System.Windows.Forms.ListBox PostalCodeList;
    }
}
