using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillyPhreshPropertiesLibrary
{
    class Showings
    {
        private string customerEmail;
        private string agent;
        private string address;
        private string city;
        private string time;
        private string buyer;
        private DateTime date;

        public Showings() { }

        public Showings(string email, string agent, string address, string city, string time, string buyer, DateTime date)
        {
            customerEmail = email;
            this.agent = agent;
            this.address = address;
            this.city = city;
            this.time = time;
            this.buyer = buyer;
            this.date = date;
        }

        //getters and setters
        public string Email
        { get { return customerEmail; } set { customerEmail = value; } }
        
        public string Agent
        { get { return agent; } set { agent = value; } }

        public string Address
        { get { return address; } set { address = value; } }

        public string City
        { get { return city; } set { city = value; } }

        public string Time
        { get { return time; } set { time = value; } }

        public string Buyer
        { get { return buyer; } set { buyer = value; } }

        public DateTime Date
        { get { return date; } set { date = value; } }

    }//end Showings class
}
