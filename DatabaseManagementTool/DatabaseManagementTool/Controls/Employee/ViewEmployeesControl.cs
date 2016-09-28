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
    public partial class ViewEmployeesControl : UserControl
    {
        List<Employee> employeeslist = new List<Employee>();

        public ViewEmployeesControl()
        {
            InitializeComponent();

            Employee oEmployee = new Employee();
            List<Employee> employees = (List<Employee>)oEmployee.FindAll();

            foreach (Employee employee in employees)
            {
                employeeslist.Add(new Employee { BSN = employee.BSN, Name = employee.Name, Surname = employee.Surname });
            }

            EmployeesList.DisplayMember = "Name";
            EmployeesList.ValueMember = "BSN";
            EmployeesList.DataSource = employeeslist;
        }

    }
}
