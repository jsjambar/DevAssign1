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
            this.EmployeeDelete = new System.Windows.Forms.Button();
            this.EmployeeEdit = new System.Windows.Forms.Button();
            this.EmployeeSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeBSN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.Location = new System.Drawing.Point(30, 29);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(120, 95);
            this.EmployeesList.TabIndex = 0;
            this.EmployeesList.SelectedIndexChanged += new System.EventHandler(this.EmployeesList_SelectedIndexChanged);
            // 
            // EmployeeDelete
            // 
            this.EmployeeDelete.Location = new System.Drawing.Point(208, 165);
            this.EmployeeDelete.Name = "EmployeeDelete";
            this.EmployeeDelete.Size = new System.Drawing.Size(75, 23);
            this.EmployeeDelete.TabIndex = 24;
            this.EmployeeDelete.Text = "Delete";
            this.EmployeeDelete.UseVisualStyleBackColor = true;
            this.EmployeeDelete.Click += new System.EventHandler(this.EmployeeDelete_Click);
            // 
            // EmployeeEdit
            // 
            this.EmployeeEdit.Location = new System.Drawing.Point(208, 135);
            this.EmployeeEdit.Name = "EmployeeEdit";
            this.EmployeeEdit.Size = new System.Drawing.Size(75, 23);
            this.EmployeeEdit.TabIndex = 23;
            this.EmployeeEdit.Text = "Edit";
            this.EmployeeEdit.UseVisualStyleBackColor = true;
            this.EmployeeEdit.Click += new System.EventHandler(this.EmployeeEdit_Click);
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.AutoSize = true;
            this.EmployeeSurname.Location = new System.Drawing.Point(291, 71);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeSurname.Size = new System.Drawing.Size(49, 13);
            this.EmployeeSurname.TabIndex = 18;
            this.EmployeeSurname.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Surname";
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.AutoSize = true;
            this.EmployeeFirstName.Location = new System.Drawing.Point(291, 55);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(55, 13);
            this.EmployeeFirstName.TabIndex = 16;
            this.EmployeeFirstName.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "First name";
            // 
            // EmployeeBSN
            // 
            this.EmployeeBSN.AutoSize = true;
            this.EmployeeBSN.Location = new System.Drawing.Point(291, 39);
            this.EmployeeBSN.Name = "EmployeeBSN";
            this.EmployeeBSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeBSN.Size = new System.Drawing.Size(29, 13);
            this.EmployeeBSN.TabIndex = 14;
            this.EmployeeBSN.Text = "BSN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "BSN";
            // 
            // ViewEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeDelete);
            this.Controls.Add(this.EmployeeEdit);
            this.Controls.Add(this.EmployeeSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployeeFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeBSN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeesList);
            this.Name = "ViewEmployeesControl";
            this.Size = new System.Drawing.Size(545, 227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesList;
        private System.Windows.Forms.Button EmployeeDelete;
        private System.Windows.Forms.Button EmployeeEdit;
        private System.Windows.Forms.Label EmployeeSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmployeeFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EmployeeBSN;
        private System.Windows.Forms.Label label1;
    }
}
