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
            Address address = new Address { ID = Int32.Parse(this.AddressID.Text), Street = AddressStreet.Text, Number = Int32.Parse(AddressNumber.Text.ToString()) };
            address.Update(address);
            this.AddItemsToListBox();
            this.FeedbackLabel.ForeColor = Color.ForestGreen;
            this.FeedbackLabel.Text = $"Updated address to '{AddressStreet.Text} {AddressNumber.Text}'";
        }

        private void AddItemsToListBox()
        {
            this.AddressList.Items.Clear();

            foreach (Address a in this.Address.FindAll())
            {
                this.AddressList.Items.Add(a.Street);
            }
        }

        private void AddressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var address_list = this.Address.FindAll();

            foreach (Address address in address_list)
            {
                if (this.AddressList.SelectedItem.ToString() == address.Street)
                {
                    this.AddressID.Text = address.ID.ToString();
                    this.AddressStreet.Text = address.Street.ToString();
                    this.AddressNumber.Text = address.Number.ToString();
                }
            }
        }
    }
}
