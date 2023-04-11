using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using PhillyPhreshPropertiesLibrary;
using System.Data;
using System.Data.SqlClient;

namespace PhillyPhreshProperties
{
    public partial class AddAHomeProfile : System.Web.UI.Page
    {
        StoredProcedures procedures = new StoredProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string address = "";
            string propertyType = ddlPropertyType.SelectedValue;
            string homeSize = "";
            string bedrooms = "";
            string bathrooms = "";
            string amenities = chkAmenities.SelectedValue;
            string heatingCooling = ddlHeatingCooling.SelectedValue;
            string yearBuilt = "";
            string garage = ddlGarage.SelectedValue;
            string homeDescription = "";
            string askingPrice = "";
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblMessage.Text += "Please enter an address for the home. </br>";
                flag = false;
            }
            else
            {
                address = txtAddress.Text;
            }


            if (string.IsNullOrWhiteSpace(txtHomeSize.Text))
            {
                lblMessage.Text += "Please enter the size of the home in sq ft. </br>";
                flag = false;
            }
            else
            {
                homeSize = txtHomeSize.Text;
            }


            if (string.IsNullOrWhiteSpace(txtNumBedrooms.Text))
            {
                lblMessage.Text += "Please enter the number of bedrooms. </br>";
                flag = false;
            }
            else if (txtNumBedrooms.Text.All(Char.IsDigit) == false)
            {
                lblMessage.Text += "Number of bedrooms should only be in numbers. </br>";
            }
            else
            {
                bedrooms = txtNumBedrooms.Text;
            }


            if (string.IsNullOrWhiteSpace(txtNumBathrooms.Text))
            {
                lblMessage.Text += "Please enter the number of bathrooms. </br>";
                flag = false;
            }
            else if (txtNumBathrooms.Text.All(Char.IsDigit) == false)
            {
                lblMessage.Text += "Number of bathrooms must only be numbers. </br>";
            }
            else
            {
                bathrooms = txtNumBathrooms.Text;
            }


            if (string.IsNullOrWhiteSpace(txtYearBuilt.Text))
            {
                lblMessage.Text += "Please enter the date house was built. </br>";
                flag = false;
            }
            else
            {
                yearBuilt = txtYearBuilt.Text;
            }


            if (string.IsNullOrWhiteSpace(descriptionTxtBox.Text))
            {
                lblMessage.Text += "Please enter a description of the house. </br>";
                flag = false;
            }
            else
            {
                homeDescription = descriptionTxtBox.Text;
            }


            if (string.IsNullOrWhiteSpace(askingPriceTxtBox.Text))
            {
                lblMessage.Text += "Please enter your last name. </br>";
                flag = false;
            }
          else
            {
                askingPrice = askingPriceTxtBox.Text;
            }

            if (flag == true)
            {
                if (procedures.AddHouse()
                {
                    lblMessage.Text += "New user added to Philly Phresh Properties!";
                }
                else
                {
                    lblMessage.Text += "There was an error adding user";
                }
            }
        }
    }
}