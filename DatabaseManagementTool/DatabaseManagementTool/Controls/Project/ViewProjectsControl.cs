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

namespace DatabaseManagementTool
{
    public partial class ViewProjectsControl : UserControl
    {
        Project oProject = new Project();
        List<Project> projectslist = new List<Project>();
        int current = 0;

        public ViewProjectsControl()
        {
            InitializeComponent();

            List<Project> projects = (List<Project>)oProject.FindAll();

            foreach (Project project in projects)
            {
                projectslist.Add(new Project { Id = project.Id, Name = project.Name, Location = project.Location, Budget = project.Budget, Hours = project.Hours });
            }
            
            ProjectList.DisplayMember = "Name";
            ProjectList.ValueMember = "Id";
            ProjectList.DataSource = projectslist;
    }

        // To view the data before choosing whether you want to delete or edit
        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = ProjectList.SelectedIndex;

            if(selectedId >= 0)
            {
                var values = projectslist[selectedId];
                current = values.Id;

                ProjectId.Text = values.Id.ToString();
                ProjectName.Text = values.Name.ToString();
                ProjectLocation.Text = values.Location.ToString();
                ProjectBudget.Text = values.Budget.ToString();
                ProjectHours.Text = values.Hours.ToString();
            }
        }

        private void ProjectEdit_Click(object sender, EventArgs e)
        {
            oProject.Update(new Project { Id = current, Name = ProjectName.Text, Location = ProjectLocation.Text, Budget = Convert.ToInt32(ProjectBudget.Text), Hours = Convert.ToInt32(ProjectHours.Text) });
        }

        private void ProjectDelete_Click(object sender, EventArgs e)
        {
            oProject.Delete(current);
        }
    }
}
