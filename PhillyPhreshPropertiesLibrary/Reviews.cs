using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillyPhreshPropertiesLibrary
{
    public class Reviews : EventArgs
    {
        string name;
        int rating;
        string priceComment;
        string locationComment;
        string homeComment;



        public Reviews()
        {

        }

        public Reviews(string Name, int Rating, string PriceComment, string LocationComment, string HomeComment)
        {
            name = Name;
            rating = Rating;
            priceComment = PriceComment;
            locationComment = LocationComment;
            homeComment = HomeComment;
        }

       public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public string PriceComment
        {
            get { return priceComment; }
            set { priceComment = value; }
        }
        public string LocationComment
        {
            get { return locationComment; }
            set { locationComment = value; }
        }
        public string HomeCOmment
        {
            get { return homeComment; }
            set { homeComment = value; }
        }
    }
}
