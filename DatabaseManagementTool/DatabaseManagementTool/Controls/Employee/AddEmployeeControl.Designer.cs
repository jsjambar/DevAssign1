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
            this.EmployeeEducation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeBSN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.RolesList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddEmployeeControlTitle
            // 
            this.AddEmployeeControlTitle.AutoSize = true;
            this.AddEmployeeControlTitle.Location = new System.Drawing.Point(54, 33);
            this.AddEmployeeControlTitle.Name = "AddEmployeeControlTitle";
            this.AddEmployeeControlTitle.Size = new System.Drawing.Size(93, 13);
            this.AddEmployeeControlTitle.TabIndex = 0;
            this.AddEmployeeControlTitle.Text = "Create a new user";
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Location = new System.Drawing.Point(51, 138);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.EmployeeFirstName.TabIndex = 1;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Location = new System.Drawing.Point(51, 184);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.EmployeeSurname.TabIndex = 2;
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(189, 346);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.CreateEmployeeButton.TabIndex = 3;
            this.CreateEmployeeButton.Text = "Create employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // EmployeeEducation
            // 
            this.EmployeeEducation.Location = new System.Drawing.Point(189, 86);
            this.EmployeeEducation.Name = "EmployeeEducation";
            this.EmployeeEducation.Size = new System.Drawing.Size(100, 20);
            this.EmployeeEducation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Education";
            // 
            // EmployeeBSN
            // 
            this.EmployeeBSN.Location = new System.Drawing.Point(51, 86);
            this.EmployeeBSN.Name = "EmployeeBSN";
            this.EmployeeBSN.Size = new System.Drawing.Size(100, 20);
            this.EmployeeBSN.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "BSN";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(51, 346);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View employees";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RolesList
            // 
            this.RolesList.FormattingEnabled = true;
            this.RolesList.Location = new System.Drawing.Point(189, 138);
            this.RolesList.Name = "RolesList";
            this.RolesList.Size = new System.Drawing.Size(120, 95);
            this.RolesList.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Role";
            // 
            // AddressesList
            // 
            this.AddressesList.FormattingEnabled = true;
            this.AddressesList.Location = new System.Drawing.Point(51, 245);
            this.AddressesList.Name = "AddressesList";
            this.AddressesList.Size = new System.Drawing.Size(120, 69);
            this.AddressesList.TabIndex = 19;
            // 
            // AddEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressesList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RolesList);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmployeeBSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeEducation);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.EmployeeSurname);
            this.Controls.Add(this.EmployeeFirstName);
            this.Controls.Add(this.AddEmployeeControlTitle);
            this.Name = "AddEmployeeControl";
            this.Size = new System.Drawing.Size(727, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEmployeeControlTitle;
        private System.Windows.Forms.TextBox EmployeeFirstName;
        private System.Windows.Forms.TextBox EmployeeSurname;
        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.TextBox EmployeeEducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeBSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox RolesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox AddressesList;
    }
}
