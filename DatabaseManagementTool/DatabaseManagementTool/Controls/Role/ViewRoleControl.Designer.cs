namespace DatabaseManagementTool
{
    partial class ViewRoleControl
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
            this.RoleID = new System.Windows.Forms.TextBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoleSaveButton = new System.Windows.Forms.Button();
            this.RoleName = new System.Windows.Forms.TextBox();
            this.RoleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RoleID
            // 
            this.RoleID.Location = new System.Drawing.Point(173, 58);
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Size = new System.Drawing.Size(100, 20);
            this.RoleID.TabIndex = 13;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(177, 179);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(71, 13);
            this.FeedbackLabel.TabIndex = 12;
            this.FeedbackLabel.Text = "Update a role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Click on a role to select";
            // 
            // RoleSaveButton
            // 
            this.RoleSaveButton.Location = new System.Drawing.Point(173, 130);
            this.RoleSaveButton.Name = "RoleSaveButton";
            this.RoleSaveButton.Size = new System.Drawing.Size(75, 23);
            this.RoleSaveButton.TabIndex = 10;
            this.RoleSaveButton.Text = "Save";
            this.RoleSaveButton.UseVisualStyleBackColor = true;
            this.RoleSaveButton.Click += new System.EventHandler(this.RoleSaveButton_Click);
            // 
            // RoleName
            // 
            this.RoleName.Location = new System.Drawing.Point(173, 94);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(100, 20);
            this.RoleName.TabIndex = 9;
            // 
            // RoleList
            // 
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Location = new System.Drawing.Point(30, 58);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(120, 134);
            this.RoleList.TabIndex = 8;
            this.RoleList.SelectedIndexChanged += new System.EventHandler(this.RoleList_SelectedIndexChanged);
            // 
            // ViewRoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoleID);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoleSaveButton);
            this.Controls.Add(this.RoleName);
            this.Controls.Add(this.RoleList);
            this.Name = "ViewRoleControl";
            this.Size = new System.Drawing.Size(549, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoleID;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RoleSaveButton;
        private System.Windows.Forms.TextBox RoleName;
        private System.Windows.Forms.ListBox RoleList;
    }
}
