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
    public partial class ViewPostalCodeControl : UserControl
    {
        PostalCode PostalCode = new PostalCode();

        public ViewPostalCodeControl()
        {
            InitializeComponent();
            this.AddItemsToListBox();
        }

        private void PostalCodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var postal_code_list = this.PostalCode.FindAll();

            foreach (PostalCode pc in postal_code_list)
            {
                if (this.PostalCodeList.SelectedItem.ToString() == pc.Code)
                {
                    this.PostalCodeID.Text = pc.ID.ToString();
                    this.PostalCodeName.Text = pc.Code.ToString();
                    this.PostalCodeCity.Text = pc.City.ToString();
                }
            }
        }

        private void PostalCodeSaveButton_Click(object sender, EventArgs e)
        {
            PostalCode postal_code = new PostalCode { ID = Int32.Parse(this.PostalCodeID.Text), Code = this.PostalCodeName.Text.ToString(), City = this.PostalCodeCity.Text.ToString() };
            postal_code.Update(postal_code);
            this.AddItemsToListBox();
            this.FeedbackLabel.ForeColor = Color.ForestGreen;
            this.FeedbackLabel.Text = $"Updated postal code with {this.PostalCodeName.Text.ToString()} and set city to {this.PostalCodeCity.Text.ToString()}";
        }

        private void AddItemsToListBox()
        {
            this.PostalCodeList.Items.Clear();

            foreach (PostalCode pc in this.PostalCode.FindAll())
            {
                this.PostalCodeList.Items.Add(pc.Code);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new AddPostalCodeControl());
        }
    }
}
