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

            employeeslist.Add(new Employee { BSN = 1, Name = "Ginny", Surname = "Weet ik niet" });
            employeeslist.Add(new Employee { BSN = 1, Name = "Harry", Surname = "Weet ik niet 2" });
            employeeslist.Add(new Employee { BSN = 1, Name = "Bart", Surname = "Weet ik niet 3" });

            EmployeesList.DisplayMember = "Name";
            EmployeesList.ValueMember = "BSN";
            EmployeesList.DataSource = employeeslist;
        }

    }
}
