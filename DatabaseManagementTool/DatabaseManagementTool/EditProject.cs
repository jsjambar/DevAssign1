using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementTool
{
    public partial class EditProject : UserControl
    {
        string id = "1";
        string name = "name";
        string location = "somewhere";
        string hours = "25";
        string budget = "36";

        public EditProject()
        {
            InitializeComponent();
            ProjectID.Text = id;
            ProjectName.Text = name;
            ProjectLocation.Text = location;
            ProjectHours.Text = hours;
            ProjectBudget.Text = budget;
        }

        private void ProjectSave_Click(object sender, EventArgs e)
        {
            name = ProjectName.Text;
            location = ProjectLocation.Text;
            hours = ProjectHours.Text;
            budget = ProjectBudget.Text;
        }
    }
}
