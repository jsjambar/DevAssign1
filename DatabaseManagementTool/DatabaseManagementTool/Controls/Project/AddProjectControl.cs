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
    public partial class AddProjectControl : UserControl
    {
        string name;
        string location;
        string budget;
        string hours;

        public AddProjectControl()
        {
            InitializeComponent();
            Country country = new Country();
            country.FindAll();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            Project project = new Project { Name = ProjectName.Text, Location = "Test", Hours = Convert.ToInt32(ProjectHours.Text), Budget = Convert.ToInt32(ProjectBudget.Text) };
            project.Create(project);
        }
    }
}
