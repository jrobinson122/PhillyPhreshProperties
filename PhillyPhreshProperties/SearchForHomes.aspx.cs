using System;
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
using PhillyPhreshPropertiesAPI;
using System.Data;
using System.Data.SqlClient;



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

        protected void Button1_Click(object sender, EventArgs e)
        {

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
                //lblMessage.Text = "No records found by those values";
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

        //protected void btnViewHomeDetails_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int homeID = Convert.ToInt32((sender as Button).CommandArgument);
        //        WebRequest request = WebRequest.Create(webApiUrl + "GetHomesByID/" + homeID);
        //        WebResponse response = request.GetResponse();

        //        Stream theDataStream = response.GetResponseStream();
        //        StreamReader reader = new StreamReader(theDataStream);
        //        String data = reader.ReadToEnd();
        //        reader.Close();
        //        response.Close();

        //        JavaScriptSerializer js = new JavaScriptSerializer();
        //        List<Home> homes = js.Deserialize<List<Home>>(data);
        //        gvHomes.DataSource = homes;
        //        gvHomes.DataBind();

        //        ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "showModal()", true);
        //    }
        //    catch(Exception ex)
        //    {
        //        lblMessage.Text += "Something went wrong";
        //    }

            //if (homes.Count == 0)
            //{
            //    lblMessage.Text = "No records found by those values";
            //}
       // }

        private Home ShowHomeDetails(int homeId)
        {
            Home homeDetails = new Home();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetHomeByID";
            objCommand.Parameters.AddWithValue("@theHomeID", homeId);
            gvHomes.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            return homeDetails;
        }

        //protected void btnViewDetails_Click(object sender, EventArgs e)
        //{
        //    Button btnViewDetails = (Button)sender;
        //    GridViewRow row = (GridViewRow)btnViewDetails.NamingContainer;
           
        //    string address = gvHomes.DataKeys[row.RowIndex].Values["Address"].ToString();
        //    string city = gvHomes.DataKeys[row.RowIndex].Values["City"].ToString();
        //    string propertyType = gvHomes.DataKeys[row.RowIndex].Values["PropertyType"].ToString();
        //    int homeSize = Convert.ToInt32(gvHomes.DataKeys[row.RowIndex].Values["HomeSize"].ToString());
        //    string amenities = gvHomes.DataKeys[row.RowIndex].Values["Amenities"].ToString();
        //    string heatingCooling = gvHomes.DataKeys[row.RowIndex].Values["HeatingCooling"].ToString();
        //    int yearBuilt = Convert.ToInt32(gvHomes.DataKeys[row.RowIndex].Values["YearBuilt"].ToString());
        //    string garage = gvHomes.DataKeys[row.RowIndex].Values["Garage"].ToString();
        //    decimal askingPrice = Convert.ToDecimal(gvHomes.DataKeys[row.RowIndex].Values["AskingPrice"].ToString());

        //    // Retrieve other home data from the data source

        //    // Populate the modal popup with the home data
        //    addressModalLbl.Text = address;
        //    cityModalLbl.Text = city;
        //    propertyTypeModalLbl.Text = propertyType;
        //    homeSizeLbl.Text = homeSize.ToString();
        //    amenitiesModalLbl.Text = amenities;
        //    heatingCoolingModalLbl.Text = heatingCooling;
        //    yearBuiltModalLbl.Text = yearBuilt.ToString();
        //    garageModalLbl.Text = garage;
        //    askingPriceModalLbl.Text = askingPrice.ToString();


        //    // Set other labels or controls in the modal popup with the retrieved home data

        //    // Show the modal popup
        //    AjaxModalDetails.Show();
        //}

        protected void btnClose_Click(object sender, EventArgs e)
        {
           
        }

       

        protected void gvHomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewHomeInfo")
            {
               
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvHomes.Rows[rowIndex];
                string address = row.Cells[0].Text;
                string city = row.Cells[1].Text;
                string propertyType = row.Cells[2].Text;
                int homeSize = Convert.ToInt32(row.Cells[3].Text);
                string amenities = row.Cells[4].Text;
                string heatingCooling = row.Cells[5].Text;
                int yearBuilt = Convert.ToInt32(row.Cells[6].Text);
                string garage = row.Cells[7].Text;
                decimal askingPrice = Convert.ToDecimal(row.Cells[8].Text);

                //string city = gvHomes.DataKeys[rowIndex].Values["City"].ToString();
                //string propertyType = gvHomes.DataKeys[rowIndex].Values["PropertyType"].ToString();
                //int homeSize = Convert.ToInt32(gvHomes.DataKeys[rowIndex].Values["HomeSize"].ToString());
                //string amenities = gvHomes.DataKeys[rowIndex].Values["Amenities"].ToString();
                //string heatingCooling = gvHomes.DataKeys[rowIndex].Values["HeatingCooling"].ToString();
                //int yearBuilt = Convert.ToInt32(gvHomes.DataKeys[rowIndex].Values["YearBuilt"].ToString());
                //string garage = gvHomes.DataKeys[rowIndex].Values["Garage"].ToString();
                //decimal askingPrice = Convert.ToDecimal(gvHomes.DataKeys[rowIndex].Values["AskingPrice"].ToString());

                //string address = ((Label)row.FindControl("Address")).Text;
                //string city = ((Label)row.FindControl("City")).Text;
                //string propertyType = ((Label)row.FindControl("PropertyType")).Text;
                //int homeSize = Convert.ToInt32(((Label)row.FindControl("HomeSize")).Text);
                //string amenities = ((Label)row.FindControl("Amenities")).Text;
                //string heatingCooling = ((Label)row.FindControl("HeatingCooling")).Text;
                //int yearBuilt = Convert.ToInt32(((Label)row.FindControl("YearBuilt")).Text);
                //string garage = ((Label)row.FindControl("Garage")).Text;
                //decimal askingPrice = Convert.ToDecimal(((Label)row.FindControl("AskingPrice")).Text);

                addressModalLbl.Text = address;
                cityModalLbl.Text = city;
                propertyTypeModalLbl.Text = propertyType;
                homeSizeModalLbl.Text = homeSize.ToString();
                amenitiesModalLbl.Text = amenities;
                heatingCoolingModalLbl.Text = heatingCooling;
                yearBuiltModalLbl.Text = yearBuilt.ToString();
                garageModalLbl.Text = garage;
                askingPriceModalLbl.Text = askingPrice.ToString();
                pnlHomeDetails.Visible = true;

            }
        }

      }
    }

     
