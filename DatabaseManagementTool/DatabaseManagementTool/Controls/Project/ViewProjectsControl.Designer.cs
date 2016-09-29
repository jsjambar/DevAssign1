namespace DatabaseManagementTool
{
    partial class ViewProjectsControl
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
            this.ProjectList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectHours = new System.Windows.Forms.Label();
            this.ProjectBudget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectEdit = new System.Windows.Forms.Button();
            this.ProjectDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectList
            // 
            this.ProjectList.FormattingEnabled = true;
            this.ProjectList.Location = new System.Drawing.Point(13, 13);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(120, 95);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // ProjectID
            // 
            this.ProjectID.AutoSize = true;
            this.ProjectID.Location = new System.Drawing.Point(244, 21);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectID.Size = new System.Drawing.Size(18, 13);
            this.ProjectID.TabIndex = 2;
            this.ProjectID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Location = new System.Drawing.Point(244, 37);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(35, 13);
            this.ProjectName.TabIndex = 4;
            this.ProjectName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location";
            // 
            // ProjectLocation
            // 
            this.ProjectLocation.AutoSize = true;
            this.ProjectLocation.Location = new System.Drawing.Point(244, 53);
            this.ProjectLocation.Name = "ProjectLocation";
            this.ProjectLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectLocation.Size = new System.Drawing.Size(48, 13);
            this.ProjectLocation.TabIndex = 6;
            this.ProjectLocation.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Allocated hours";
            // 
            // ProjectHours
            // 
            this.ProjectHours.AutoSize = true;
            this.ProjectHours.Location = new System.Drawing.Point(244, 70);
            this.ProjectHours.Name = "ProjectHours";
            this.ProjectHours.Size = new System.Drawing.Size(35, 13);
            this.ProjectHours.TabIndex = 8;
            this.ProjectHours.Text = "Hours";
            // 
            // ProjectBudget
            // 
            this.ProjectBudget.AutoSize = true;
            this.ProjectBudget.Location = new System.Drawing.Point(244, 85);
            this.ProjectBudget.Name = "ProjectBudget";
            this.ProjectBudget.Size = new System.Drawing.Size(41, 13);
            this.ProjectBudget.TabIndex = 9;
            this.ProjectBudget.Text = "Budget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Budget";
            // 
            // ProjectEdit
            // 
            this.ProjectEdit.Location = new System.Drawing.Point(161, 117);
            this.ProjectEdit.Name = "ProjectEdit";
            this.ProjectEdit.Size = new System.Drawing.Size(75, 23);
            this.ProjectEdit.TabIndex = 11;
            this.ProjectEdit.Text = "Edit";
            this.ProjectEdit.UseVisualStyleBackColor = true;
            this.ProjectEdit.Click += new System.EventHandler(this.ProjectEdit_Click);
            // 
            // ProjectDelete
            // 
            this.ProjectDelete.Location = new System.Drawing.Point(163, 147);
            this.ProjectDelete.Name = "ProjectDelete";
            this.ProjectDelete.Size = new System.Drawing.Size(75, 23);
            this.ProjectDelete.TabIndex = 12;
            this.ProjectDelete.Text = "Delete";
            this.ProjectDelete.UseVisualStyleBackColor = true;
            this.ProjectDelete.Click += new System.EventHandler(this.ProjectDelete_Click);
            // 
            // ViewProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectDelete);
            this.Controls.Add(this.ProjectEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProjectBudget);
            this.Controls.Add(this.ProjectHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectList);
            this.Name = "ViewProjectsControl";
            this.Size = new System.Drawing.Size(489, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProjectID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProjectLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProjectHours;
        private System.Windows.Forms.Label ProjectBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ProjectEdit;
        private System.Windows.Forms.Button ProjectDelete;
    }
}
