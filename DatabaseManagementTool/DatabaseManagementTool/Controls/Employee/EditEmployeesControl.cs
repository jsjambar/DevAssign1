using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementTool.Controls.Employee
{
    public partial class EditEmployeesControl : UserControl
    {
        public EditEmployeesControl()
        {
            InitializeComponent();
        }

        private void EmployeesBack_Click(object sender, EventArgs e)
        {
            testlbl.Text = "Okee?";
        }
    }
}
