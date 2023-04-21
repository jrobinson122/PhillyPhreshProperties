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
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace PhillyPhreshProperties
{
    public partial class AddAHomeProfile : System.Web.UI.Page
    {
        String webApiUrl = "http://localhost:57085/api/Properties/";
        StoredProcedures procedures = new StoredProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            //Create an object of the Home class 
            Home home = new Home();
            home.Address = txtAddress.Text;
            home.City = txtCity.Text;
            home.PropertyType = ddlPropertyType.SelectedValue;
            home.HomeSize = Convert.ToInt32(txtHomeSize.Text);
            home.Bedrooms = Convert.ToInt32(txtNumBedrooms.Text);
            home.Bathrooms = Convert.ToInt32(txtNumBathrooms.Text);
            home.Amenities = chkAmenities.SelectedValue;
            home.HeatingCooling = ddlHeatingCooling.SelectedValue;
            home.YearBuilt = Convert.ToInt32(txtYearBuilt.Text);
            home.Garage = ddlGarage.SelectedValue;
            home.HomeDescription = descriptionTxtBox.Text;
            home.AskingPrice = Convert.ToDecimal(askingPriceTxtBox.Text);
                

            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonHome = js.Serialize(home);
            try
            {
                WebRequest request = WebRequest.Create(webApiUrl + "AddAHome/");
                request.Method = "POST";
                request.ContentLength = jsonHome.Length;
                request.ContentType = "application/json";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonHome);
                writer.Flush();
                writer.Close();

                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();
                if (data == "true")
                {
                    lblMessage.Text += "Successfully listed!";
                }
                else
                {
                    lblMessage.Text += "Error listing property";
                }
            }
            catch(Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
    






            //    bool flag = true;
            //    string address = "";
            //    string propertyType = ddlPropertyType.SelectedValue;
            //    string homeSize = "";
            //    string bedrooms = "";
            //    string bathrooms = "";
            //    string amenities = chkAmenities.SelectedValue;
            //    string heatingCooling = ddlHeatingCooling.SelectedValue;
            //    string yearBuilt = "";
            //    string garage = ddlGarage.SelectedValue;
            //    string homeDescription = "";
            //    string askingPrice = "";
            //    lblMessage.Text = "";

//    if (string.IsNullOrWhiteSpace(txtAddress.Text))
//    {
//        lblMessage.Text += "Please enter an address for the home. </br>";
//        flag = false;
//    }
//    else
//    {
//        address = txtAddress.Text;
//    }


//    if (string.IsNullOrWhiteSpace(txtHomeSize.Text))
//    {
//        lblMessage.Text += "Please enter the size of the home in sq ft. </br>";
//        flag = false;
//    }
//    else if(txtHomeSize.Text.All(Char.IsDigit) == false)
//    {
//        lblMessage.Text += "Please enter the size in numbers. </br>";
//    }
//    else
//    {
//        homeSize = txtHomeSize.Text;
//    }


//    if (string.IsNullOrWhiteSpace(txtNumBedrooms.Text))
//    {
//        lblMessage.Text += "Please enter the number of bedrooms. </br>";
//        flag = false;
//    }
//    else if (txtNumBedrooms.Text.All(Char.IsDigit) == false)
//    {
//        lblMessage.Text += "Number of bedrooms should only be in numbers. </br>";
//    }
//    else
//    {
//        bedrooms = txtNumBedrooms.Text;
//    }


//    if (string.IsNullOrWhiteSpace(txtNumBathrooms.Text))
//    {
//        lblMessage.Text += "Please enter the number of bathrooms. </br>";
//        flag = false;
//    }
//    else if (txtNumBathrooms.Text.All(Char.IsDigit) == false)
//    {
//        lblMessage.Text += "Number of bathrooms must only be numbers. </br>";
//    }
//    else
//    {
//        bathrooms = txtNumBathrooms.Text;
//    }


//    if (string.IsNullOrWhiteSpace(txtYearBuilt.Text))
//    {
//        lblMessage.Text += "Please enter the date house was built. </br>";
//        flag = false;
//    }
//    else if(txtYearBuilt.Text.All(char.IsDigit) == false)
//    {
//        lblMessage.Text += "Please enter a numerical year";
//    }
//    else
//    {
//        yearBuilt = txtYearBuilt.Text;
//    }


//    if (string.IsNullOrWhiteSpace(descriptionTxtBox.Text))
//    {
//        lblMessage.Text += "Please enter a description of the house. </br>";
//        flag = false;
//    }
//    else
//    {
//        homeDescription = descriptionTxtBox.Text;
//    }


//    if (string.IsNullOrWhiteSpace(askingPriceTxtBox.Text))
//    {
//        lblMessage.Text += "Please enter your last name. </br>";
//        flag = false;
//    }
//    else if(askingPriceTxtBox.Text.All(Char.IsDigit) == false)
//    {
//        lblMessage.Text += "Please enter a number only. </br>";

//    }
//  else
//    {
//        askingPrice = askingPriceTxtBox.Text;
//    }

//    if (flag == true)
//    {
//        if (procedures.AddHouse(address, propertyType, homeSize, bedrooms, bathrooms, amenities, heatingCooling, yearBuilt, garage, homeDescription, askingPrice))
//        {
//            lblMessage.Text += "New house added to Philly Phresh Properties!";
//        }
//        else
//        {
//            lblMessage.Text += "There was an error adding a home";
//        }
//    }
//}