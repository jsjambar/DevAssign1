namespace DatabaseManagementTool
{
    partial class ViewEmployeesControl
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
            this.EmployeesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.Location = new System.Drawing.Point(30, 29);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(120, 95);
            this.EmployeesList.TabIndex = 0;
            // 
            // ViewEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeesList);
            this.Name = "ViewEmployeesControl";
            this.Size = new System.Drawing.Size(545, 227);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesList;
    }
}
