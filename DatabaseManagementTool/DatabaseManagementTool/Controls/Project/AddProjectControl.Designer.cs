namespace DatabaseManagementTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectLocation = new System.Windows.Forms.TextBox();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.ProjectBudget = new System.Windows.Forms.TextBox();
            this.ProjectHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(40, 62);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(100, 20);
            this.ProjectName.TabIndex = 2;
            // 
            // ProjectLocation
            // 
            this.ProjectLocation.Location = new System.Drawing.Point(43, 125);
            this.ProjectLocation.Name = "ProjectLocation";
            this.ProjectLocation.Size = new System.Drawing.Size(100, 20);
            this.ProjectLocation.TabIndex = 3;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(203, 92);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(75, 23);
            this.AddProjectButton.TabIndex = 4;
            this.AddProjectButton.Text = "Add";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // ProjectBudget
            // 
            this.ProjectBudget.Location = new System.Drawing.Point(43, 184);
            this.ProjectBudget.Name = "ProjectBudget";
            this.ProjectBudget.Size = new System.Drawing.Size(100, 20);
            this.ProjectBudget.TabIndex = 5;
            // 
            // ProjectHours
            // 
            this.ProjectHours.Location = new System.Drawing.Point(203, 62);
            this.ProjectHours.Name = "ProjectHours";
            this.ProjectHours.Size = new System.Drawing.Size(100, 20);
            this.ProjectHours.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Allocated hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Budget";
            // 
            // AddProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectHours);
            this.Controls.Add(this.ProjectBudget);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.ProjectLocation);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProjectControl";
            this.Size = new System.Drawing.Size(558, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectLocation;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.TextBox ProjectBudget;
        private System.Windows.Forms.TextBox ProjectHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
