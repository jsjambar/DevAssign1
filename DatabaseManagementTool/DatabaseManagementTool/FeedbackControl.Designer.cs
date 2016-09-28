namespace DatabaseManagementTool
{
    partial class FeedbackControl
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
            this.OperationFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OperationFeedback
            // 
            this.OperationFeedback.AutoSize = true;
            this.OperationFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationFeedback.ForeColor = System.Drawing.Color.ForestGreen;
            this.OperationFeedback.Location = new System.Drawing.Point(3, 0);
            this.OperationFeedback.Name = "OperationFeedback";
            this.OperationFeedback.Size = new System.Drawing.Size(66, 24);
            this.OperationFeedback.TabIndex = 0;
            this.OperationFeedback.Text = "label1";
            // 
            // FeedbackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OperationFeedback);
            this.Name = "FeedbackControl";
            this.Size = new System.Drawing.Size(210, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OperationFeedback;
    }
}
