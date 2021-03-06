﻿using System;
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
    public partial class AddPostalCodeControl : UserControl
    {
        public AddPostalCodeControl()
        {
            InitializeComponent();
        }

        private void PostalCodeSaveButton_Click(object sender, EventArgs e)
        {
            PostalCode postal_code = new PostalCode { Code = PostalCodeValue.Text.ToString(), City = PostalCodeCity.Text.ToString()};
            postal_code.Create(postal_code);
            FeedbackLabel.Text = $"Postal code with the value of {postal_code.Code}, located in {postal_code.City} saved.";
            PostalCodeValue.Text = "";
            PostalCodeValue.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helpers.SetControl(this, new ViewPostalCodeControl());
        }
    }
}
