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
    public partial class AddEmployeeControl : UserControl
    {
        string name;
        string surname;
        string address;
        string education;
        string job;

        public AddEmployeeControl()
        {
            InitializeComponent();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee { BSN = Int32.Parse(EmployeeBSN.Text), Name = EmployeeFirstName.Text, Surname = EmployeeSurname.Text };
            employee.Create(employee);
        }
    }
}
