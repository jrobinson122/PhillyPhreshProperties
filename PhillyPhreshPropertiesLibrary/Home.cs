﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillyPhreshPropertiesLibrary
{
   public class Home
    {
        string address;
        string city;
        string propertyType;
        int homeSize;
        int bedrooms;
        int bathrooms;
        string amenities;
        string heatingCooling;
        int yearBuilt;
        string garage;
        string homeDescription;
        decimal askingPrice;

        public Home()
        {

        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string PropertyType
        {
            get { return propertyType; }
            set { propertyType = value; }
        }
        public int HomeSize
        {
            get { return homeSize; }
            set { homeSize = value; }
        }
        public int Bedrooms
        {
            get { return bedrooms; }
            set { bedrooms = value; }
        }
        public int Bathrooms
        {
            get { return bathrooms; }
            set { bathrooms = value; }
        }
        public string Amenities
        {
            get { return amenities; }
            set { amenities = value; }
        }
        public string HeatingCooling
        {
            get { return heatingCooling; }
            set { heatingCooling = value; }
        }
        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }
        public string Garage
        {
            get { return garage; }
            set { garage = value; }
        }
        public string HomeDescription
        {
            get { return homeDescription; }
            set { homeDescription = value; }
        }
        public decimal AskingPrice
        {
            get { return askingPrice; }
            set { askingPrice = value; }
        }








    }
}
