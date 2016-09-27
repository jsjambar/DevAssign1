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
        List<Project> projectslist = new List<Project>();
        int current = 0;

        public ViewProjectsControl()
        {
            InitializeComponent();
            projectslist.Add(new Project { Id = 1, Name = "Project 1", Location = "Ergens 1", Hours = 30, Budget = 4000 });
            projectslist.Add(new Project { Id = 2, Name = "Project 2", Location = "Ergens 2", Hours = 20, Budget = 2000 });
            projectslist.Add(new Project { Id = 3, Name = "Project 3", Location = "Ergens 3", Hours = 5, Budget = 50 });

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

                ProjectID.Text = values.Id.ToString();
                ProjectName.Text = values.Name.ToString();
                ProjectLocation.Text = values.Location.ToString();
                label69.Text = values.Budget.ToString();
                ProjectHours.Text = values.Hours.ToString();
            }
        }

        private void ProjectEdit_Click(object sender, EventArgs e)
        {

        }

        private void ProjectDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
