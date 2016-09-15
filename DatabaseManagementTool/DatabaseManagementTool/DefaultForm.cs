using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementTool
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetScreenInformation("This application is an assignment for Hogeschool Rotterdam and is made by Jason Sjambar and Andy Bhadai");
            this.SetStatusScreenText("Application information");
        }

        private void SetScreenInformation(string text)
        {
            this.ScreenInformation.Text = text;
        }

        private void SetStatusScreenText(string text)
        {
            this.StatusLabel.Text = text;
        }

        private void addEmployeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // To do: Add form
        }
    }
}
