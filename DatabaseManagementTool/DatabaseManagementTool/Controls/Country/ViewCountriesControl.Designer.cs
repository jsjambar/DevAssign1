namespace DatabaseManagementTool
{
    partial class ViewCountriesControl
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
            this.CountryList = new System.Windows.Forms.ListBox();
            this.CountryName = new System.Windows.Forms.TextBox();
            this.CountrySaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.CountryID = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CountryList
            // 
            this.CountryList.FormattingEnabled = true;
            this.CountryList.Location = new System.Drawing.Point(20, 79);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(120, 134);
            this.CountryList.TabIndex = 0;
            this.CountryList.SelectedIndexChanged += new System.EventHandler(this.CountryList_SelectedIndexChanged);
            // 
            // CountryName
            // 
            this.CountryName.Location = new System.Drawing.Point(163, 115);
            this.CountryName.Name = "CountryName";
            this.CountryName.Size = new System.Drawing.Size(100, 20);
            this.CountryName.TabIndex = 1;
            this.CountryName.TextChanged += new System.EventHandler(this.CountryName_TextChanged);
            // 
            // CountrySaveButton
            // 
            this.CountrySaveButton.Location = new System.Drawing.Point(163, 151);
            this.CountrySaveButton.Name = "CountrySaveButton";
            this.CountrySaveButton.Size = new System.Drawing.Size(75, 23);
            this.CountrySaveButton.TabIndex = 2;
            this.CountrySaveButton.Text = "Save";
            this.CountrySaveButton.UseVisualStyleBackColor = true;
            this.CountrySaveButton.Click += new System.EventHandler(this.CountrySaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click on a country to select";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(160, 195);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(89, 13);
            this.FeedbackLabel.TabIndex = 6;
            this.FeedbackLabel.Text = "Update a country";
            this.FeedbackLabel.Click += new System.EventHandler(this.FeedbackLabel_Click);
            // 
            // CountryID
            // 
            this.CountryID.Location = new System.Drawing.Point(163, 79);
            this.CountryID.Name = "CountryID";
            this.CountryID.ReadOnly = true;
            this.CountryID.Size = new System.Drawing.Size(100, 20);
            this.CountryID.TabIndex = 7;
            this.CountryID.TextChanged += new System.EventHandler(this.CountryID_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create a new country";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ViewCountriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CountryID);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountrySaveButton);
            this.Controls.Add(this.CountryName);
            this.Controls.Add(this.CountryList);
            this.Name = "ViewCountriesControl";
            this.Size = new System.Drawing.Size(593, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CountryList;
        private System.Windows.Forms.TextBox CountryName;
        private System.Windows.Forms.Button CountrySaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.TextBox CountryID;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
