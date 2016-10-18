﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagementTool.Classes;

namespace DatabaseManagementTool
{
    public partial class AddEmployeeControl : UserControl
    {
        public AddEmployeeControl()
        {
            InitializeComponent();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee { BSN = Int32.Parse(EmployeeBSN.Text), Name = EmployeeFirstName.Text, Surname = EmployeeSurname.Text, Address = EmployeeAddress.Text, Education = EmployeeEducation.Text, Job = EmployeeJob.Text };
            employee.Create(employee);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new ViewEmployeesControl());
        }
    }
}
