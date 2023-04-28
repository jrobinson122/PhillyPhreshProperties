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
        DateTime date = DateTime.Today;
        string time = "";
        string agent;
        string buyer;
        string email;
        string type;
        bool success = false;
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();

        protected void Page_Load(object sender, EventArgs e)
        {
            byte[] emailData = (byte[])Session["Email"];
            stream = new MemoryStream(emailData);
            email = (string)formatter.Deserialize(stream);

            byte[] typeData = (byte[])Session["AccountType"];
            stream = new MemoryStream(typeData);
            type = (string)formatter.Deserialize(stream);

            email = "GavinIrons@gmail.com";
            type = "Buyer";

            user = procedure.LoadUser(email, type);                

            //Response.Write(procedure.LoadBuyerShowings(user.Email).ToString());
                       
        }

        public string LoadShowings()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(procedure.LoadBuyerShowings(email));
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            rptShowings.DataSource = procedure.LoadBuyerShowings(user.Email);
            rptShowings.DataBind();

        }//end btnRefresh_Click()

        protected void btnSchedule_Click(object sender, EventArgs e)
        {
            Validation();

            if (!lblError.Visible)
            {
                if(ddlDate.SelectedValue == "1")
                {
                    date = DateTime.Today.AddDays(1).Date;
                }
                else if(ddlDate.SelectedValue == "2")
                {
                    date = DateTime.Today.AddDays(2).Date;
                }
                else if(ddlDate.SelectedValue == "3")
                {
                    date = DateTime.Today.AddDays(3).Date;
                }
                else if (ddlDate.SelectedValue == "4")
                {
                    date = DateTime.Today.AddDays(4).Date;
                }
                else if (ddlDate.SelectedValue == "5")
                {
                    date = DateTime.Today.AddDays(5).Date;
                }
                else if (ddlDate.SelectedValue == "6")
                {
                    date = DateTime.Today.AddDays(7).Date;
                }

                if(ddlTime.SelectedValue == "1")
                {
                    time = ddlTime.Items.FindByValue("1").Text;
                }
                else if (ddlTime.SelectedValue == "2")
                {
                    time = ddlTime.Items.FindByValue("2").Text;
                }
                else if(ddlTime.SelectedValue == "3")
                {
                    time = ddlTime.Items.FindByValue("3").Text;
                }
                else if(ddlTime.SelectedValue == "4")
                {
                    time = ddlTime.Items.FindByValue("4").Text;
                }
                else if(ddlTime.SelectedValue == "5")
                {
                    time = ddlTime.Items.FindByValue("5").Text;
                }
                else if(ddlTime.SelectedValue == "6")
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