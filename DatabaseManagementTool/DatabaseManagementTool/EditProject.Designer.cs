namespace DatabaseManagementTool
{
    partial class EditProject
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
            this.ProjectSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectID = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectLocation = new System.Windows.Forms.TextBox();
            this.ProjectHours = new System.Windows.Forms.TextBox();
            this.ProjectBudget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectSave
            // 
            this.ProjectSave.Location = new System.Drawing.Point(232, 46);
            this.ProjectSave.Name = "ProjectSave";
            this.ProjectSave.Size = new System.Drawing.Size(75, 23);
            this.ProjectSave.TabIndex = 0;
            this.ProjectSave.Text = "Save";
            this.ProjectSave.UseVisualStyleBackColor = true;
            this.ProjectSave.Click += new System.EventHandler(this.ProjectSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // ProjectID
            // 
            this.ProjectID.Location = new System.Drawing.Point(71, 20);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(100, 20);
            this.ProjectID.TabIndex = 2;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(71, 48);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(100, 20);
            this.ProjectName.TabIndex = 3;
            // 
            // ProjectLocation
            // 
            this.ProjectLocation.Location = new System.Drawing.Point(71, 75);
            this.ProjectLocation.Name = "ProjectLocation";
            this.ProjectLocation.Size = new System.Drawing.Size(100, 20);
            this.ProjectLocation.TabIndex = 4;
            // 
            // ProjectHours
            // 
            this.ProjectHours.Location = new System.Drawing.Point(71, 102);
            this.ProjectHours.Name = "ProjectHours";
            this.ProjectHours.Size = new System.Drawing.Size(100, 20);
            this.ProjectHours.TabIndex = 5;
            // 
            // ProjectBudget
            // 
            this.ProjectBudget.Location = new System.Drawing.Point(71, 129);
            this.ProjectBudget.Name = "ProjectBudget";
            this.ProjectBudget.Size = new System.Drawing.Size(100, 20);
            this.ProjectBudget.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Budget";
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectBudget);
            this.Controls.Add(this.ProjectHours);
            this.Controls.Add(this.ProjectLocation);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectSave);
            this.Name = "EditProject";
            this.Size = new System.Drawing.Size(572, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProjectSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectID;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectLocation;
        private System.Windows.Forms.TextBox ProjectHours;
        private System.Windows.Forms.TextBox ProjectBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
