using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PhillyPhreshProperties
{
    public partial class Showings_Agent : System.Web.UI.Page
    {
        StoredProcedures procedure = new StoredProcedures();
        User agent = new User();
        string email;
        string type;
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();
        Offer homeOffer = new Offer();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                byte[] emailData = (byte[])Session["Email"];
                stream = new MemoryStream(emailData);
                email = (string)formatter.Deserialize(stream);

                byte[] typeData = (byte[])Session["AccountType"];
                stream = new MemoryStream(typeData);
                type = (string)formatter.Deserialize(stream);

                agent = procedure.LoadUser(email, type);
                string name = agent.FirstName + " " + agent.LastName;

                rptShowings.DataSource = procedure.LoadAgentShowings("Max Goof");// send name here
                rptShowings.DataBind();
            }

        }

        protected void rptShowings_ItemCommand(Object sender, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Offer")
            {
                int row = e.Item.ItemIndex;

                Label address = (Label)rptShowings.Items[row].FindControl("lblProperty");
                Label buyer = (Label)rptShowings.Items[row].FindControl("lblBuyer");

                homeOffer = procedure.GetOffer(buyer.Text, address.Text);
                ViewOffers view = (ViewOffers)LoadControl("ViewOffers.ascx");

                if(homeOffer != null)
                {
                    view.FillLabels(homeOffer.Buyer, homeOffer.Agent, homeOffer.Address, homeOffer.City, homeOffer.AskingPrice, homeOffer.HomeOffer);
                    Form.Controls.Add(view);

                    divOffer.Visible = true;
                }
                

            }

        }
}