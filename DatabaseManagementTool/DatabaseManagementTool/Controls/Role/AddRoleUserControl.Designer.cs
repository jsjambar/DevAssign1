namespace DatabaseManagementTool
{
    partial class AddRoleUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.RoleValue = new System.Windows.Forms.TextBox();
            this.RoleSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(33, 138);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(81, 13);
            this.FeedbackLabel.TabIndex = 7;
            this.FeedbackLabel.Text = "FeedbackLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Create employe job roles";
            // 
            // RoleValue
            // 
            this.RoleValue.Location = new System.Drawing.Point(36, 63);
            this.RoleValue.Name = "RoleValue";
            this.RoleValue.Size = new System.Drawing.Size(100, 20);
            this.RoleValue.TabIndex = 5;
            // 
            // RoleSaveButton
            // 
            this.RoleSaveButton.Location = new System.Drawing.Point(36, 99);
            this.RoleSaveButton.Name = "RoleSaveButton";
            this.RoleSaveButton.Size = new System.Drawing.Size(75, 23);
            this.RoleSaveButton.TabIndex = 4;
            this.RoleSaveButton.Text = "Create";
            this.RoleSaveButton.UseVisualStyleBackColor = true;
            this.RoleSaveButton.Click += new System.EventHandler(this.RoleSaveButton_Click);
            // 
            // AddRoleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleValue);
            this.Controls.Add(this.RoleSaveButton);
            this.Name = "AddRoleUserControl";
            this.Size = new System.Drawing.Size(279, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoleValue;
        private System.Windows.Forms.Button RoleSaveButton;
    }
}
