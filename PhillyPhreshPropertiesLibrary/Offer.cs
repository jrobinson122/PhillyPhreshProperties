using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillyPhreshPropertiesLibrary
{
    public class Offer
    {
        string address;
        string city;
        string buyer;
        string agent;
        decimal askingPrice;
        decimal homeOffer;
        string accepted;

        public Offer()
        {

        }

        public Offer(string buyer, string agent, string address, string city, decimal askingPrice, decimal offer, string accepted)
        {
            this.buyer = buyer;
            this.agent = agent;
            this.address = address;
            this.city = city;
            this.askingPrice = askingPrice;
            this.homeOffer = offer;
            this.accepted = accepted;
        }

        public string Agent
        { get { return agent; } set { agent = value; } }

        public string Address
        { get { return address; } set { address = value; } }

        public string City
        { get { return city; } set { city = value; } }

        public string Buyer
        { get { return buyer; } set { buyer = value; } }

        public decimal AskingPrice
        { get { return askingPrice; } set { askingPrice = value; } }

        public decimal HomeOffer
        { get { return homeOffer; } set { homeOffer = value; } }

        public string Accepted
        { get { return accepted; } set { accepted = value; } }
    }
}
