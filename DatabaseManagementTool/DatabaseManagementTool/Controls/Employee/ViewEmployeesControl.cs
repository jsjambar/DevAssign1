﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagementTool.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DatabaseManagementTool.Classes;

namespace DatabaseManagementTool
{
    public partial class ViewEmployeesControl : UserControl
    {
        List<Employee> employeeslist = new List<Employee>();
        int current = 0;
        int selectedId = 0;
        Employee oEmployee = new Employee();

        public ViewEmployeesControl()
        {
            InitializeComponent();
            
            List<Employee> employees = (List<Employee>)oEmployee.FindAll();

            foreach (Employee employee in employees)
            {
                employeeslist.Add(new Employee { BSN = employee.BSN, Name = employee.Name, Surname = employee.Surname, Address = employee.Address, Education = employee.Education, Job = employee.Job });
            }

            EmployeesList.DisplayMember = "Name";
            EmployeesList.ValueMember = "BSN";
            EmployeesList.DataSource = employeeslist;
        }

        private void EmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EmployeeEdit_Click(object sender, EventArgs e)
        {
            oEmployee.Update(new Employee { BSN = current, Name = EmployeeFirstName.Text, Surname = EmployeeSurname.Text, Address = EmployeeAddress.Text, Education = EmployeeEducation.Text, Job = EmployeeJob.Text });
        }

        private void EmployeeDelete_Click(object sender, EventArgs e)
        {
            oEmployee.Delete(current);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new AddEmployeeControl());
        }
    }
}
