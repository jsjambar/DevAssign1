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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectEdit = new System.Windows.Forms.Button();
            this.ProjectDelete = new System.Windows.Forms.Button();
            this.ProjectId = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectLocation = new System.Windows.Forms.TextBox();
            this.ProjectHours = new System.Windows.Forms.TextBox();
            this.ProjectBudget = new System.Windows.Forms.TextBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ProjectList
            // 
            this.ProjectList.FormattingEnabled = true;
            this.ProjectList.Location = new System.Drawing.Point(58, 64);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(120, 95);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Allocated hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Budget";
            // 
            // ProjectEdit
            // 
            this.ProjectEdit.Location = new System.Drawing.Point(277, 191);
            this.ProjectEdit.Name = "ProjectEdit";
            this.ProjectEdit.Size = new System.Drawing.Size(75, 23);
            this.ProjectEdit.TabIndex = 11;
            this.ProjectEdit.Text = "Save";
            this.ProjectEdit.UseVisualStyleBackColor = true;
            this.ProjectEdit.Click += new System.EventHandler(this.ProjectEdit_Click);
            // 
            // ProjectDelete
            // 
            this.ProjectDelete.Location = new System.Drawing.Point(61, 165);
            this.ProjectDelete.Name = "ProjectDelete";
            this.ProjectDelete.Size = new System.Drawing.Size(75, 23);
            this.ProjectDelete.TabIndex = 12;
            this.ProjectDelete.Text = "Delete";
            this.ProjectDelete.UseVisualStyleBackColor = true;
            this.ProjectDelete.Click += new System.EventHandler(this.ProjectDelete_Click);
            // 
            // ProjectId
            // 
            this.ProjectId.Enabled = false;
            this.ProjectId.Location = new System.Drawing.Point(277, 75);
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            this.ProjectId.Size = new System.Drawing.Size(100, 20);
            this.ProjectId.TabIndex = 13;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(277, 98);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(100, 20);
            this.ProjectName.TabIndex = 14;
            // 
            // ProjectLocation
            // 
            this.ProjectLocation.Location = new System.Drawing.Point(277, 121);
            this.ProjectLocation.Name = "ProjectLocation";
            this.ProjectLocation.Size = new System.Drawing.Size(100, 20);
            this.ProjectLocation.TabIndex = 15;
            // 
            // ProjectHours
            // 
            this.ProjectHours.Location = new System.Drawing.Point(277, 143);
            this.ProjectHours.Name = "ProjectHours";
            this.ProjectHours.Size = new System.Drawing.Size(100, 20);
            this.ProjectHours.TabIndex = 16;
            // 
            // ProjectBudget
            // 
            this.ProjectBudget.Location = new System.Drawing.Point(277, 165);
            this.ProjectBudget.Name = "ProjectBudget";
            this.ProjectBudget.Size = new System.Drawing.Size(100, 20);
            this.ProjectBudget.TabIndex = 17;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(55, 228);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.FeedbackLabel.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create project";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ViewProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.ProjectBudget);
            this.Controls.Add(this.ProjectHours);
            this.Controls.Add(this.ProjectLocation);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ProjectId);
            this.Controls.Add(this.ProjectDelete);
            this.Controls.Add(this.ProjectEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ProjectEdit;
        private System.Windows.Forms.Button ProjectDelete;
        private System.Windows.Forms.TextBox ProjectId;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectLocation;
        private System.Windows.Forms.TextBox ProjectHours;
        private System.Windows.Forms.TextBox ProjectBudget;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
