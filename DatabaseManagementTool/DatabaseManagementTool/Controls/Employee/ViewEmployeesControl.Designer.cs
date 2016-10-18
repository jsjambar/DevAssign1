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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeBSN = new System.Windows.Forms.TextBox();
            this.EmployeeFirstName = new System.Windows.Forms.TextBox();
            this.EmployeeSurname = new System.Windows.Forms.TextBox();
            this.EmployeeEducation = new System.Windows.Forms.TextBox();
            this.EmployeeAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeJob = new System.Windows.Forms.TextBox();
            this.lbl23 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.Location = new System.Drawing.Point(3, 3);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(120, 95);
            this.EmployeesList.TabIndex = 0;
            this.EmployeesList.SelectedIndexChanged += new System.EventHandler(this.EmployeesList_SelectedIndexChanged);
            // 
            // EmployeeDelete
            // 
            this.EmployeeDelete.Location = new System.Drawing.Point(3, 104);
            this.EmployeeDelete.Name = "EmployeeDelete";
            this.EmployeeDelete.Size = new System.Drawing.Size(75, 23);
            this.EmployeeDelete.TabIndex = 24;
            this.EmployeeDelete.Text = "Delete";
            this.EmployeeDelete.UseVisualStyleBackColor = true;
            this.EmployeeDelete.Click += new System.EventHandler(this.EmployeeDelete_Click);
            // 
            // EmployeeEdit
            // 
            this.EmployeeEdit.Location = new System.Drawing.Point(226, 136);
            this.EmployeeEdit.Name = "EmployeeEdit";
            this.EmployeeEdit.Size = new System.Drawing.Size(75, 23);
            this.EmployeeEdit.TabIndex = 23;
            this.EmployeeEdit.Text = "Edit";
            this.EmployeeEdit.UseVisualStyleBackColor = true;
            this.EmployeeEdit.Click += new System.EventHandler(this.EmployeeEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "BSN";
            // 
            // EmployeeBSN
            // 
            this.EmployeeBSN.Enabled = false;
            this.EmployeeBSN.Location = new System.Drawing.Point(201, 5);
            this.EmployeeBSN.Name = "EmployeeBSN";
            this.EmployeeBSN.Size = new System.Drawing.Size(100, 20);
            this.EmployeeBSN.TabIndex = 25;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Location = new System.Drawing.Point(201, 27);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.EmployeeFirstName.TabIndex = 26;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Location = new System.Drawing.Point(201, 48);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.EmployeeSurname.TabIndex = 27;
            // 
            // EmployeeEducation
            // 
            this.EmployeeEducation.Location = new System.Drawing.Point(201, 90);
            this.EmployeeEducation.Name = "EmployeeEducation";
            this.EmployeeEducation.Size = new System.Drawing.Size(100, 20);
            this.EmployeeEducation.TabIndex = 31;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.Location = new System.Drawing.Point(201, 69);
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.Size = new System.Drawing.Size(100, 20);
            this.EmployeeAddress.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Education";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Address";
            // 
            // EmployeeJob
            // 
            this.EmployeeJob.Location = new System.Drawing.Point(201, 111);
            this.EmployeeJob.Name = "EmployeeJob";
            this.EmployeeJob.Size = new System.Drawing.Size(100, 20);
            this.EmployeeJob.TabIndex = 33;
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.Location = new System.Drawing.Point(129, 114);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(24, 13);
            this.lbl23.TabIndex = 32;
            this.lbl23.Text = "Job";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 13);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create a new employee";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ViewEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.EmployeeJob);
            this.Controls.Add(this.lbl23);
            this.Controls.Add(this.EmployeeEducation);
            this.Controls.Add(this.EmployeeAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeSurname);
            this.Controls.Add(this.EmployeeFirstName);
            this.Controls.Add(this.EmployeeBSN);
            this.Controls.Add(this.EmployeeDelete);
            this.Controls.Add(this.EmployeeEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeBSN;
        private System.Windows.Forms.TextBox EmployeeFirstName;
        private System.Windows.Forms.TextBox EmployeeSurname;
        private System.Windows.Forms.TextBox EmployeeEducation;
        private System.Windows.Forms.TextBox EmployeeAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeJob;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
