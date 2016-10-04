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
                }
            }
        }

        private void PostalCodeSaveButton_Click(object sender, EventArgs e)
        {
            PostalCode postal_code = new PostalCode { ID = Int32.Parse(this.PostalCodeID.Text), Code = this.PostalCodeID.Text };
            postal_code.Update(postal_code);
            this.AddItemsToListBox();
        }

        private void AddItemsToListBox()
        {
            this.PostalCodeList.Items.Clear();

            foreach (PostalCode pc in this.PostalCode.FindAll())
            {
                this.PostalCodeList.Items.Add(pc.Code);
            }
        }
    }
}
