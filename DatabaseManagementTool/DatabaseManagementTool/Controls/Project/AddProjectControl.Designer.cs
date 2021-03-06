﻿namespace DatabaseManagementTool
{
    partial class AddProjectControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectBudget = new System.Windows.Forms.TextBox();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectSaveButton = new System.Windows.Forms.Button();
            this.ProjectAllocatedHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // ProjectBudget
            // 
            this.ProjectBudget.Location = new System.Drawing.Point(170, 93);
            this.ProjectBudget.Name = "ProjectBudget";
            this.ProjectBudget.Size = new System.Drawing.Size(100, 20);
            this.ProjectBudget.TabIndex = 12;
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(24, 213);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.FeedbackLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Create projects";
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(170, 67);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(100, 20);
            this.ProjectName.TabIndex = 9;
            // 
            // ProjectSaveButton
            // 
            this.ProjectSaveButton.Location = new System.Drawing.Point(170, 163);
            this.ProjectSaveButton.Name = "ProjectSaveButton";
            this.ProjectSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ProjectSaveButton.TabIndex = 8;
            this.ProjectSaveButton.Text = "Create";
            this.ProjectSaveButton.UseVisualStyleBackColor = true;
            this.ProjectSaveButton.Click += new System.EventHandler(this.ProjectSaveButton_Click);
            // 
            // ProjectAllocatedHours
            // 
            this.ProjectAllocatedHours.Location = new System.Drawing.Point(170, 119);
            this.ProjectAllocatedHours.Name = "ProjectAllocatedHours";
            this.ProjectAllocatedHours.Size = new System.Drawing.Size(100, 20);
            this.ProjectAllocatedHours.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Allocated hours";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 259);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View all projects";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // AddProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProjectAllocatedHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectBudget);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ProjectSaveButton);
            this.Name = "AddProjectControl";
            this.Size = new System.Drawing.Size(770, 319);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectBudget;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Button ProjectSaveButton;
        private System.Windows.Forms.TextBox ProjectAllocatedHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
