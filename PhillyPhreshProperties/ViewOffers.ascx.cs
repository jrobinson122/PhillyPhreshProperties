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
using System.ComponentModel;

namespace PhillyPhreshProperties
{
    public partial class ViewOffers : System.Web.UI.UserControl
    {
        StoredProcedures procedure = new StoredProcedures();
        Offer offer = new Offer();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Category("Appearance")]
        public void FillLabels(string buyer, string agent, string address, string city, decimal askingPrice, decimal offer)
        {
            lblBuyer.Text = buyer;
            lblAgent.Text = agent;
            lblAddress.Text = address;
            lblCity.Text = city;
            lblAskingPrice.Text = askingPrice.ToString();
            lblOffer.Text = offer.ToString();
        }

        protected void btnDecline_Click(object sender, EventArgs e)
        {
            offer.Buyer = lblBuyer.Text;
            offer.Agent = lblAgent.Text;
            offer.Address = lblAddress.Text;
            offer.City = lblCity.Text;
            offer.AskingPrice = Convert.ToDecimal(lblAskingPrice.Text);
            offer.HomeOffer = Convert.ToDecimal(lblOffer.Text);
            offer.Accepted = "No";

            procedure.SetOfferStatus(offer);
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            offer.Buyer = lblBuyer.Text;
            offer.Agent = lblAgent.Text;
            offer.Address = lblAddress.Text;
            offer.City = lblCity.Text;
            offer.AskingPrice = Convert.ToDecimal(lblAskingPrice.Text);
            offer.HomeOffer = Convert.ToDecimal(lblOffer.Text);
            offer.Accepted = "Yes";

            procedure.SetOfferStatus(offer);
        }
    }
}