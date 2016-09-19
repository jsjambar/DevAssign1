﻿namespace DatabaseManagementTool
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
            this.EmployeeAddress = new System.Windows.Forms.TextBox();
            this.EmployeeEducation = new System.Windows.Forms.TextBox();
            this.EmployeeJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.EmployeeFirstName.Location = new System.Drawing.Point(40, 88);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.EmployeeFirstName.TabIndex = 1;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Location = new System.Drawing.Point(40, 134);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.EmployeeSurname.TabIndex = 2;
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(188, 184);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.CreateEmployeeButton.TabIndex = 3;
            this.CreateEmployeeButton.Text = "Create employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.Location = new System.Drawing.Point(40, 184);
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.Size = new System.Drawing.Size(100, 20);
            this.EmployeeAddress.TabIndex = 4;
            // 
            // EmployeeEducation
            // 
            this.EmployeeEducation.Location = new System.Drawing.Point(188, 88);
            this.EmployeeEducation.Name = "EmployeeEducation";
            this.EmployeeEducation.Size = new System.Drawing.Size(100, 20);
            this.EmployeeEducation.TabIndex = 5;
            // 
            // EmployeeJob
            // 
            this.EmployeeJob.Location = new System.Drawing.Point(188, 138);
            this.EmployeeJob.Name = "EmployeeJob";
            this.EmployeeJob.Size = new System.Drawing.Size(100, 20);
            this.EmployeeJob.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Education";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Job";
            // 
            // AddEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeJob);
            this.Controls.Add(this.EmployeeEducation);
            this.Controls.Add(this.EmployeeAddress);
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
        private System.Windows.Forms.TextBox EmployeeAddress;
        private System.Windows.Forms.TextBox EmployeeEducation;
        private System.Windows.Forms.TextBox EmployeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
