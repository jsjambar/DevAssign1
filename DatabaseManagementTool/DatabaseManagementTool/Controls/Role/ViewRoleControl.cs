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
    public partial class ViewRoleControl : UserControl
    {
        Role Role = new Role();

        public ViewRoleControl()
        {
            InitializeComponent();
            this.AddItemsToListBox();
        }

        private void RoleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var role_list = this.Role.FindAll();

            foreach(Role role in role_list)
            {
                if(this.RoleList.SelectedItem.ToString() == role.Name)
                {
                    this.RoleID.Text = role.ID.ToString();
                    this.RoleName.Text = role.Name.ToString();
                }
            }
        }

        private void RoleSaveButton_Click(object sender, EventArgs e)
        {
            Role role = new Role { ID = Int32.Parse(this.RoleID.Text), Name = RoleName.Text };
            role.Update(role);
            this.AddItemsToListBox();
            this.FeedbackLabel.ForeColor = Color.ForestGreen;
            this.FeedbackLabel.Text = $"Updated role to {RoleName.Text}";
        }

        private void AddItemsToListBox()
        {
            this.RoleList.Items.Clear();

            foreach (Role r in this.Role.FindAll())
            {
                this.RoleList.Items.Add(r.Name);
            }
        }
    }
}
