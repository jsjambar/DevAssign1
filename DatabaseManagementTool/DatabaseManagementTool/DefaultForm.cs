using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Controls.Country;
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

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.CreateDatabase();
        }

        private void AddControlToPlaceHolder(Control Control)
        {
            this.ControlPlaceholder.Controls.Clear();
            this.ControlPlaceholder.Controls.Add(Control);
        }

        private void RemoveControlFromPlaceHolder(Control Control)
        {
            this.ControlPlaceholder.Controls.Remove(Control);
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddControlToPlaceHolder(new AddEmployeeControl());
        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddControlToPlaceHolder(new ViewProjectsControl());
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddControlToPlaceHolder(new AddProjectControl());
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddControlToPlaceHolder(new ViewEmployeesControl());
        }

        private void createAllTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database database = new Database();
        }

        private void addCountriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.AddControlToPlaceHolder(new AddCountryControl());
        }

        private void addCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddControlToPlaceHolder(new ViewCountriesControl());
        }
    }
}
