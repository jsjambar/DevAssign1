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
    public partial class ViewCountriesControl : UserControl
    {
        Country Country = new Country(); 

        public ViewCountriesControl()
        {
            InitializeComponent();
            this.AddItemsToListBox();
        }

        private void CountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var country_list = this.Country.FindAll();

            foreach(Country country in country_list)
            {
                if(this.CountryList.SelectedItem.ToString() == country.Name)
                {
                    this.CountryID.Text = country.ID.ToString();
                    this.CountryName.Text = country.Name.ToString();
                }
            }
        }

        private void CountrySaveButton_Click(object sender, EventArgs e)
        {
            Country country = new Country { ID = Int32.Parse(this.CountryID.Text), Name = CountryName.Text };
            country.Update(country);
            this.AddItemsToListBox();
            this.FeedbackLabel.ForeColor = Color.ForestGreen;
            this.FeedbackLabel.Text = $"Updated country to {CountryName.Text}";
        }

        private void AddItemsToListBox()
        {
            this.CountryList.Items.Clear();

            foreach (Country c in this.Country.FindAll())
            {
                this.CountryList.Items.Add(c.Name);
            }
        }

        private void FeedbackLabel_Click(object sender, EventArgs e)
        {

        }

        private void CountryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new AddCountryControl());
        }
    }
}
