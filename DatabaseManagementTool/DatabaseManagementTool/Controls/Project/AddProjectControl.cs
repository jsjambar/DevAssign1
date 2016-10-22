using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagementTool.Models;
using DatabaseManagementTool.Classes;

namespace DatabaseManagementTool
{
    public partial class AddProjectControl : UserControl
    {
        public AddProjectControl()
        {
            InitializeComponent();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new ViewProjectsControl());
        }

        private void ProjectSaveButton_Click(object sender, EventArgs e)
        {
            Project project = new Project { Name = ProjectName.Text.ToString(), Budget = Int32.Parse(ProjectBudget.Text),  AllocatedHours = Int32.Parse(ProjectAllocatedHours.Text), CountryID = 1, AddressID = 1};
            project.Create(project);

            FeedbackLabel.ForeColor = Color.ForestGreen;
            FeedbackLabel.Text = $"Project with name '{project.Name}' has been created and saved! This project has a budget of {project.Budget} and can be worked on for {project.AllocatedHours}.";

            ProjectName.Text = "";
            ProjectName.Focus();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new ViewProjectsControl());
        }
    }
}
