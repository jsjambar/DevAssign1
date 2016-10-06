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
    public partial class AddRoleUserControl : UserControl
    {
        public AddRoleUserControl()
        {
            InitializeComponent();
        }

        private void RoleSaveButton_Click(object sender, EventArgs e)
        {
            Role role = new Role { Name = RoleValue.Text };
            role.Create(role);

            FeedbackLabel.ForeColor = Color.ForestGreen;
            FeedbackLabel.Text = $"A role with the value of {role.Name} is saved";
            RoleValue.Text = "";
            RoleValue.Focus();
        }
    }
}
