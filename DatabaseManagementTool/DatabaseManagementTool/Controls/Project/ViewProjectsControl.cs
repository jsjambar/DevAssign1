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
    public partial class ViewProjectsControl : UserControl
    {
        Project Project = new Project();

        public ViewProjectsControl()
        {
            InitializeComponent();
            this.AddItemsToListBox();
        }
        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project_list = this.Project.FindAll();

            foreach (Project p in project_list)
            {
                if (this.ProjectList.SelectedItem.ToString() == p.Name.ToString())
                {
                    this.ProjectId.Text = p.ID.ToString();
                    this.ProjectName.Text = p.Name.ToString();
                    this.ProjectBudget.Text = p.Budget.ToString();
                    this.ProjectHours.Text = p.AllocatedHours.ToString();
                }
            }
        }

        private void ProjectEdit_Click(object sender, EventArgs e)
        {
            Project project = new Project { ID = Int32.Parse(this.ProjectId.Text), Name = this.ProjectName.Text.ToString(), Budget = Int32.Parse(this.ProjectBudget.Text), AllocatedHours = Int32.Parse(ProjectHours.Text)};
            project.Update(project);
            this.AddItemsToListBox();

            this.FeedbackLabel.ForeColor = Color.ForestGreen;
            this.FeedbackLabel.Text = $"Updated project with {this.ProjectName.Text.ToString()}";
        }

        private void ProjectDelete_Click(object sender, EventArgs e)
        {
        }

        private void AddItemsToListBox()
        {
            this.ProjectList.Items.Clear();

            foreach (Project p in this.Project.FindAll())
            {
                this.ProjectList.Items.Add(p.Name);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new AddProjectControl());
        }
    }
}
