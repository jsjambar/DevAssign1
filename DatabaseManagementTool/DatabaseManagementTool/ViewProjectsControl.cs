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

        public ViewProjectsControl()
        {
            InitializeComponent();
            projectslist.Add(new Project { Id = 1, Name = "Project 1", Location = "Ergens 1" });
            projectslist.Add(new Project { Id = 2, Name = "Project 2", Location = "Ergens 2" });
            projectslist.Add(new Project { Id = 3, Name = "Project 3", Location = "Ergens 3" });

            ProjectList.DisplayMember = "Name";
            ProjectList.ValueMember = "Id";
            ProjectList.DataSource = projectslist;
        }
    }
}
