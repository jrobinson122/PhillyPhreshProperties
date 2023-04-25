﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using System.Data;
using Utilities;
using PhillyPhreshPropertiesLibrary;

//using PhillyPhreshPropertiesAPI;



namespace PhillyPhreshProperties
{
    public partial class SearchForHomes : System.Web.UI.Page
    {
            String webApiUrl = "http://localhost:57085/api/Properties/";
            protected void Page_Load(object sender, EventArgs e)
            {
           // Create an HTTP Web Request and get the HTTP Web Response from the server.
            WebRequest request = WebRequest.Create(webApiUrl + "GetHouses/");
            WebResponse response = request.GetResponse();
            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            // Deserialize a JSON string that contains an array of JSON objects into an Array of Team objects.
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Home> homes = js.Deserialize<List<Home>>(data);
            // Bind the list to the GridView to display all homes.
            gvHomes.DataSource = homes;
            gvHomes.DataBind();
            gvHomes.Visible = true;
        }

        protected void displayHomesBtn_Click(object sender, EventArgs e)
        {
          
        }

     

        protected void searchByCityAndPriceBtn_Click(object sender, EventArgs e)
        {
            CriteriaSearchTable.Visible = true;
            propertyCell.Visible = false;
        }

        protected void scheduleShowingBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowingUser.aspx");
        }

        protected void searchForHomesByCityAndPrice_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(webApiUrl + "SearchForHomeByLocationAndPrice/" + cityTxtBox.Text + "/" + minmumPricetxt.Text + "/" + maximumPricetxt.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Home> homes = js.Deserialize<List<Home>>(data);
            gvHomes.DataSource = homes;
            gvHomes.DataBind();

            cityTxtBox.Text = "";
            minmumPricetxt.Text = "";
            maximumPricetxt.Text = "";

            if (homes.Count == 0)
            {
                lblMessage.Text = "No records found by those values";
            }
        }

        protected void searchForHomesByLocationPropertyAndPriceBtn_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(webApiUrl + "SearchForHomesByLocationPropertyAndPrice/" + cityTxtBox.Text + "/" + propertyTypeDDL.SelectedValue + "/" + minmumPricetxt.Text + "/" + maximumPricetxt.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Home> homes = js.Deserialize<List<Home>>(data);
            gvHomes.DataSource = homes;
            gvHomes.DataBind();

            cityTxtBox.Text = "";
            minmumPricetxt.Text = "";
            maximumPricetxt.Text = "";
        }

        protected void searchByLocationPropertyTypeAndPrice_Click(object sender, EventArgs e)
        {
            CriteriaSearchTable.Visible = true;
            propertyCell.Visible = true;
        }

        protected void searchByLocationPricePropertySizeBedBathBtn_Click(object sender, EventArgs e)
        {
            CriteriaSearchTable.Visible = true;
            propertyCell.Visible = true;
            searchForHomesByLocationPropertyAndPriceBtn.Visible = false;
            searchForHomesByCityAndPrice.Visible = false;
        }

        protected void searchForHomesByLocationPropertyPriceAndCriteria_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(webApiUrl + "SearchForHomesByLocationPricePropertyHouseSizeMinNumBedsAndMinNumBaths/" + cityTxtBox.Text + "/" + propertyTypeDDL.SelectedValue + "/" + minmumPricetxt.Text + "/" + maximumPricetxt.Text + "/" + homeSizeTxt.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Home> homes = js.Deserialize<List<Home>>(data);
            gvHomes.DataSource = homes;
            gvHomes.DataBind();

            cityTxtBox.Text = "";
            minmumPricetxt.Text = "";
            maximumPricetxt.Text = "";
        }

    }

      
    }
