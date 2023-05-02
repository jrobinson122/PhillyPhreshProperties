using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PhillyPhreshProperties
{
    public partial class Showings_Buyer : System.Web.UI.Page
    {
        StoredProcedures procedure = new StoredProcedures();
        User user = new User();
        Home home = new Home();
        Offer homeOffer = new Offer();
        DateTime date = DateTime.Today;
        string time = "";
        string agent;
        string buyer;
        string email;
        string type;
        bool success = false;
        BinaryFormatter formatter = new BinaryFormatter();
        BinaryFormatter formatter2 = new BinaryFormatter();
        //MemoryStream stream = new MemoryStream();
        Home selectedHome = new Home();

        protected void Page_Load(object sender, EventArgs e)
        {

            byte[] emailData = (byte[])Session["User"];
            MemoryStream stream = new MemoryStream(emailData);
            email = (string)formatter.Deserialize(stream);
            type = (string)formatter.Deserialize(stream);

            

            user = procedure.LoadUser(email, type);                

            //Response.Write(procedure.LoadBuyerShowings(user.Email).ToString());
                       
        }

        public string LoadShowings()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(procedure.LoadBuyerShowings(email));
        }

        protected void btnOffer_Click(object sender, EventArgs e)
        {
            homeOffer.Buyer = user.FirstName + " " + user.LastName;
            homeOffer.Agent = procedure.GetAgent(home.City).FirstName + " " + procedure.GetAgent(home.City).LastName;
            homeOffer.Address = home.Address;
            homeOffer.City = home.City;
            homeOffer.AskingPrice = home.AskingPrice;
            homeOffer.HomeOffer = Convert.ToDecimal(txtOffer.Text);

            success = procedure.AddOffer(homeOffer.Buyer,homeOffer.Agent, homeOffer.Address, homeOffer.City, homeOffer.AskingPrice, homeOffer.HomeOffer);
            if (success)
            {

            }
            else
            {
                InputError("The offer was not sent, please reload page and try again.");
            }
        }//end btnOffer_Click()

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            rptShowings.DataSource = procedure.LoadBuyerShowings(user.Email);
            rptShowings.DataBind();

        }//end btnRefresh_Click()

        protected void rptShowings_ItemCommand(Object sender, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "Offer")
            {
                int row= e.Item.ItemIndex;

                Label address = (Label)rptShowings.Items[row].FindControl("lblAddress");

                home = procedure.GetHomeByAddress(address.Text);
                if(home == null)
                {
                    InputError("This house is not in our records please check the address and try again");
                }
                else if(home.Status == "Pending Sale" || home.Status == "Sold")
                {
                    InputError("This house is already in the proccess of being sold or is already sold, we are sorry.");
                }
                else
                {
                    //imgPhoto.ImageUrl= home.
                    lblOfferAddress.Text = home.Address;
                    lblOfferCity.Text = home.City;
                    lblStatus.Text = home.Status;
                    lblAskingPrice.Text = home.AskingPrice.ToString();
                    divOffer.Visible = true;
                }

            }

        }//end rptShowings_ItemCommand()

        protected void btnSchedule_Click(object sender, EventArgs e)
        {
            DateTime fullDate;
            Validation();

            if (!lblError.Visible)
            {
                //valid home chek
                home = procedure.GetHomeByAddress(txtAddress.Text);
                if (home == null)
                {
                    InputError("This house is not in our records please check the address and try again");
                }
                else if (home.Status == "Pending Sale" || home.Status == "Sold")
                {
                    InputError("This house is already in the proccess of being sold or is already sold, we are sorry.");
                }
                else
                {
                    if (ddlDate.SelectedValue == "1")
                    {
                        fullDate = DateTime.Today.AddDays(1);
                        date = fullDate.Date;
                    }
                    else if (ddlDate.SelectedValue == "2")
                    {
                        fullDate = DateTime.Today.AddDays(2);
                        date = fullDate.Date;
                    }
                    else if (ddlDate.SelectedValue == "3")
                    {
                        fullDate = DateTime.Today.AddDays(3);
                        date = fullDate.Date;
                    }
                    else if (ddlDate.SelectedValue == "4")
                    {
                        fullDate = DateTime.Today.AddDays(4);
                        date = fullDate.Date;
                    }
                    else if (ddlDate.SelectedValue == "5")
                    {
                        fullDate = DateTime.Today.AddDays(5);
                        date = fullDate.Date;
                    }
                    else if (ddlDate.SelectedValue == "6")
                    {
                        fullDate = DateTime.Today.AddDays(7);
                        date = fullDate.Date;
                    }

                    if (ddlTime.SelectedValue == "1")
                    {
                        time = ddlTime.Items.FindByValue("1").Text;
                    }
                    else if (ddlTime.SelectedValue == "2")
                    {
                        time = ddlTime.Items.FindByValue("2").Text;
                    }
                    else if (ddlTime.SelectedValue == "3")
                    {
                        time = ddlTime.Items.FindByValue("3").Text;
                    }
                    else if (ddlTime.SelectedValue == "4")
                    {
                        time = ddlTime.Items.FindByValue("4").Text;
                    }
                    else if (ddlTime.SelectedValue == "5")
                    {
                        time = ddlTime.Items.FindByValue("5").Text;
                    }
                    else if (ddlTime.SelectedValue == "6")
                    {
                        time = ddlTime.Items.FindByValue("6").Text;
                    }

                    buyer = user.FirstName + " " + user.LastName;
                    agent = procedure.GetAgent(txtCity.Text).FirstName + " " + procedure.GetAgent(txtCity.Text).LastName;
                    success = procedure.AddShowing(email, buyer, agent, txtAddress.Text, txtCity.Text, time, date);

                    if (success)
                    {
                        //show message showing telling buyer the showing was scheduled maybe
                    }
                    else
                    {
                        InputError("The showing was not scheduled");
                    }

                    //ScriptManager.RegisterStartupScript(this, GetType(), "loadShowings", "LoadShowings();", true);
                }//end valid home check
            }
            
        }//end btnSchedule_Click()

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session["Email"]= email;
            Session["AccountType"]= type;
            Response.Redirect("SearchForHomes.aspx");
        }//end  btnExit_Click()

        private void Validation()
        {
            if (txtAddress.Text == "")
            {
                InputError("Please enter an address above");
            }
            else if (txtCity.Text == "")
            {
                InputError("Please enter a city for the address above");
            }
            else if(ddlDate.SelectedValue == "0")
            {
                InputError("Please select a date for the showing");
            }
            else if(ddlTime.SelectedValue == "0")
            {
                InputError("Please select a time for the showing");
            }
            else
            {
                lblError.Text = "";
                lblError.Visible = false;
            }
        }//end Validation()

        public void InputError(string error)
        {
            lblError.Text = error;
            lblError.Visible = true;
        }//end InputError()

    }//end Showing-Buyer class
}