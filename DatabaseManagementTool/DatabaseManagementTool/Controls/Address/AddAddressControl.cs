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
    public partial class AddAddressUserControl : UserControl
    {
        public AddAddressUserControl()
        {
            InitializeComponent();
        }

        private void AddressSaveButton_Click(object sender, EventArgs e)
        {
            Address address = new Address { Number = Int32.Parse(AddressNumber.Text), Street = AddressStreet.Text.ToString() };
            address.Create(address);

            FeedbackLabel.ForeColor = Color.ForestGreen;
            FeedbackLabel.Text = $"Address  '{address.Street} {address.Number}' has been created and saved!";

            AddressNumber.Text = "";
            AddressStreet.Text = "";
            AddressStreet.Focus();
        }
    }
}
