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
            name = EmployeeFirstName.Text;
            surname = EmployeeSurname.Text;
            address = EmployeeAddress.Text;
            education = EmployeeEducation.Text;
            job = EmployeeJob.Text;
        }
    }
}
