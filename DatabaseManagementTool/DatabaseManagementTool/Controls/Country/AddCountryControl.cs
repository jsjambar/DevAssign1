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

namespace DatabaseManagementTool
{
    public partial class AddCountryControl : UserControl
    {
        public AddCountryControl()
        {
            InitializeComponent();
        }

        private void CountrySaveButton_Click(object sender, EventArgs e)
        {
            Country country = new Country { Name = CountryName.Text.ToString() };
            country.Create(country);

            FeedbackLabel.ForeColor = Color.ForestGreen;
            FeedbackLabel.Text = $"Country '{country.Name}' has been created and saved!";
            
            CountryName.Text = "";
            CountryName.Focus();
        }
    }
}
