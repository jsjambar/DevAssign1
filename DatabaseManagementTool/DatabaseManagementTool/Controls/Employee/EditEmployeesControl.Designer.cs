namespace DatabaseManagementTool.Controls.Employee
{
    partial class EditEmployeesControl
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
            this.testlbl = new System.Windows.Forms.Label();
            this.EmployeesBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testlbl
            // 
            this.testlbl.AutoSize = true;
            this.testlbl.Location = new System.Drawing.Point(285, 87);
            this.testlbl.Name = "testlbl";
            this.testlbl.Size = new System.Drawing.Size(38, 13);
            this.testlbl.TabIndex = 0;
            this.testlbl.Text = "Dream";
            // 
            // EmployeesBack
            // 
            this.EmployeesBack.Location = new System.Drawing.Point(48, 193);
            this.EmployeesBack.Name = "EmployeesBack";
            this.EmployeesBack.Size = new System.Drawing.Size(75, 23);
            this.EmployeesBack.TabIndex = 1;
            this.EmployeesBack.Text = "Back";
            this.EmployeesBack.UseVisualStyleBackColor = true;
            this.EmployeesBack.Click += new System.EventHandler(this.EmployeesBack_Click);
            // 
            // EditEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeesBack);
            this.Controls.Add(this.testlbl);
            this.Name = "EditEmployeesControl";
            this.Size = new System.Drawing.Size(590, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testlbl;
        private System.Windows.Forms.Button EmployeesBack;
    }
}
