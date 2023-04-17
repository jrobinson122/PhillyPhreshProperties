using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillyPhreshPropertiesLibrary
{
    public class House
    {
        private int homeID;
        private string address;
        private string propertyType;
        private string city;
        private int homeSize;
        private int numberBeds;
        private int numberBaths;
        private string amenities;
        private string hvac;
        private int yearBuilt;
        private string garage;
        private string description;
        private double askingPrice;
        private string image;

        public House() { }

        public House(int homeID, string address, string propertyType, string city, int homeSize, int numberBeds, int numberBaths, string amenities, string hvac, int yearBuilt, string garage, string description, double askingPrice, string image)
        {
            this.homeID = homeID;
            this.address = address;
            this.propertyType = propertyType;
            this.city = city;
            this.homeSize = homeSize;
            this.numberBeds = numberBeds;
            this.numberBaths = numberBaths;
            this.amenities = amenities;
            this.hvac = hvac;
            this.yearBuilt = yearBuilt;
            this.garage = garage;
            this.description = description;
            this.askingPrice = askingPrice;
            this.image = image;
        }

        //getters and setters
        public int HomeID
        { get { return homeID; } set { homeID = value; } }

        public string Address
        { get { return address; } set { address = value; } }

        public string City
        { get { return city; } set { city = value; } }

        public string PropertyType
        { get { return propertyType; } set { propertyType = value; } }

        public int HomeSize
        { get { return homeSize; } set { homeSize = value; } }

        public int NumberOfBeds
        { get { return numberBeds; } set { numberBeds = value; } }

        public int NumberOfBaths
        { get { return numberBaths; } set { numberBaths = value; } }

        public string Amenities
        { get { return amenities; } set { amenities = value; } }

        public string HeatingCooling
        { get { return hvac; } set { hvac = value; } }

        public int YearBuilt
        { get { return yearBuilt; } set { yearBuilt = value; } }

        public string Garage
        { get { return garage; } set { garage = value; } }

        public string Description
        { get { return description; } set { description = value; } }

        public double AskingPrice
        { get { return askingPrice; } set { askingPrice = value; } }

        public string Image
        { get { return image; } set { image = value; } }

    }//end House class
}
