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
    public partial class ViewAddressControl : UserControl
    {
        Address Address = new Address();

        public ViewAddressControl()
        {
            InitializeComponent();
            this.AddItemsToListBox();
        }

        private void AddressSaveButton_Click(object sender, EventArgs e)
        {
            Address address = new Address { ID = Int32.Parse(this.AddressID.Text), Street = AddressStreet.Text, Number = AddressNumber.Text.ToString() };
            address.Update(address);
            this.AddItemsToListBox();
            this.FeedbackLabel.ForeColor = Color.ForestGreen;
            this.FeedbackLabel.Text = $"Updated country to {AddressStreet.Text}";
        }

        private void AddItemsToListBox()
        {
            this.AddressList.Items.Clear();

            foreach (Address a in this.Address.FindAll())
            {
                this.AddressList.Items.Add(a);
            }
        }
    }
}
