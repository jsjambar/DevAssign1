using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagementTool.Classes;
using DatabaseManagementTool;

namespace DatabaseManagementTool
{
    public partial class AddEmployeeControl : UserControl
    {
        Role Role = new Role();
        Address Address = new Address();

        public AddEmployeeControl()
        {
            InitializeComponent();
            this.AddAddressesToList();
            this.AddRolesToList();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee { BSN = Int32.Parse(EmployeeBSN.Text), Name = EmployeeFirstName.Text, Surname = EmployeeSurname.Text, Address = AddressesList.SelectedItem.ToString(), Education = "Nothing", Job = RolesList.SelectedItem.ToString()};
            employee.Create(employee);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new ViewEmployeesControl());
        }

        private void AddRolesToList()
        {
            foreach(Role role in this.Role.FindAll())
            {
                this.RolesList.Items.Add(role.Name);
            }
        }

        private void AddAddressesToList()
        {
            foreach (Address address in this.Address.FindAll())
            {
                this.AddressesList.Items.Add(address.Street);
            }
        }
    }
}
