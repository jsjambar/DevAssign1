namespace DatabaseManagementTool
{
    partial class AddEmployeeControl
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
            this.AddEmployeeControlTitle = new System.Windows.Forms.Label();
            this.EmployeeFirstName = new System.Windows.Forms.TextBox();
            this.EmployeeSurname = new System.Windows.Forms.TextBox();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployeeControlTitle
            // 
            this.AddEmployeeControlTitle.AutoSize = true;
            this.AddEmployeeControlTitle.Location = new System.Drawing.Point(37, 38);
            this.AddEmployeeControlTitle.Name = "AddEmployeeControlTitle";
            this.AddEmployeeControlTitle.Size = new System.Drawing.Size(93, 13);
            this.AddEmployeeControlTitle.TabIndex = 0;
            this.AddEmployeeControlTitle.Text = "Create a new user";
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Location = new System.Drawing.Point(40, 70);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.EmployeeFirstName.TabIndex = 1;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Location = new System.Drawing.Point(40, 112);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.EmployeeSurname.TabIndex = 2;
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(40, 157);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.CreateEmployeeButton.TabIndex = 3;
            this.CreateEmployeeButton.Text = "Create employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.EmployeeSurname);
            this.Controls.Add(this.EmployeeFirstName);
            this.Controls.Add(this.AddEmployeeControlTitle);
            this.Name = "AddEmployeeControl";
            this.Size = new System.Drawing.Size(574, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEmployeeControlTitle;
        private System.Windows.Forms.TextBox EmployeeFirstName;
        private System.Windows.Forms.TextBox EmployeeSurname;
        private System.Windows.Forms.Button CreateEmployeeButton;
    }
}
