namespace DatabaseManagementTool
{
    partial class AddCountryControl
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
            this.AddCountryControlTitle = new System.Windows.Forms.Label();
            this.CountryName = new System.Windows.Forms.TextBox();
            this.CountrySaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCountryControlTitle
            // 
            this.AddCountryControlTitle.AutoSize = true;
            this.AddCountryControlTitle.Location = new System.Drawing.Point(23, 45);
            this.AddCountryControlTitle.Name = "AddCountryControlTitle";
            this.AddCountryControlTitle.Size = new System.Drawing.Size(87, 13);
            this.AddCountryControlTitle.TabIndex = 0;
            this.AddCountryControlTitle.Text = "Add new country";
            // 
            // CountryName
            // 
            this.CountryName.Location = new System.Drawing.Point(26, 81);
            this.CountryName.Name = "CountryName";
            this.CountryName.Size = new System.Drawing.Size(100, 20);
            this.CountryName.TabIndex = 1;
            // 
            // CountrySaveButton
            // 
            this.CountrySaveButton.Location = new System.Drawing.Point(26, 123);
            this.CountrySaveButton.Name = "CountrySaveButton";
            this.CountrySaveButton.Size = new System.Drawing.Size(100, 23);
            this.CountrySaveButton.TabIndex = 2;
            this.CountrySaveButton.Text = "Save country";
            this.CountrySaveButton.UseVisualStyleBackColor = true;
            this.CountrySaveButton.Click += new System.EventHandler(this.CountrySaveButton_Click);
            // 
            // AddCountryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountrySaveButton);
            this.Controls.Add(this.CountryName);
            this.Controls.Add(this.AddCountryControlTitle);
            this.Name = "AddCountryControl";
            this.Size = new System.Drawing.Size(432, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCountryControlTitle;
        private System.Windows.Forms.TextBox CountryName;
        private System.Windows.Forms.Button CountrySaveButton;
    }
}
