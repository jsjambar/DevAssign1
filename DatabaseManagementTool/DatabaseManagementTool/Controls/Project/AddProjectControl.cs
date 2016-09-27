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
    public partial class AddProjectControl : UserControl
    {
        string name;
        string location;
        string budget;
        string hours;

        public AddProjectControl()
        {
            InitializeComponent();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            name = ProjectName.Text;
            location = ProjectLocation.Text;
            hours = ProjectHours.Text;
            budget = ProjectBudget.Text;
        }
    }
}
