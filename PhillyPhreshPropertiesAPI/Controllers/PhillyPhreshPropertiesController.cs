using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;
using PhillyPhreshPropertiesLibrary;
using System.Data;
using System.Data.SqlClient;

namespace PhillyPhreshPropertiesAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Properties")]
    public class PhillyPhreshPropertiesController : Controller
    {
        // GET api/values
        [HttpGet("CalculateHomeSize/{x}/{y}/{z}")]
        public double CalculateHomeSize(double x, double y, double z)
        {
            double sum = x + y;
            double totalSize = sum * z;
            return totalSize;
        }

        [HttpGet]
        [HttpGet("GetHouses")]
        public List<Home> GetHouses()
        {
            List<Home> homeList = new List<Home>();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetAllHomes";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            int count = myDS.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Home homes = new Home();
                homes.Address = objDB.GetField("Address", i).ToString();
                homes.City = objDB.GetField("City", i).ToString();
                homes.PropertyType = objDB.GetField("PropertyType", i).ToString();
                homes.HomeSize = Convert.ToInt32(objDB.GetField("HomeSize", i).ToString());
                homes.Bedrooms = Convert.ToInt32(objDB.GetField("NumBeds", i).ToString());
                homes.Bathrooms = Convert.ToInt32(objDB.GetField("NumBath", i).ToString());
                homes.Amenities = objDB.GetField("Amenities", i).ToString();
                homes.HeatingCooling = objDB.GetField("HeatingCooling", i).ToString();
                homes.YearBuilt = Convert.ToInt32(objDB.GetField("YearBuilt", i).ToString());
                homes.Garage = objDB.GetField("Garage", i).ToString();
                homes.HomeDescription = objDB.GetField("Description", i).ToString();
                homes.AskingPrice = Convert.ToDecimal(objDB.GetField("AskingPrice", i).ToString());
                homeList.Add(homes);
            }
            return homeList;
        }
        [HttpGet("GetHomesByID/{id}")]
        public List<Home> GetHomesByID(int id)
        {
            List<Home> homeList = new List<Home>();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetHomeByID";
            objCommand.Parameters.AddWithValue("@theHomeID", id);
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            int count = myDS.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Home homes = new Home();
                homes.Address = objDB.GetField("Address", i).ToString();
                homes.City = objDB.GetField("City", i).ToString();
                homes.PropertyType = objDB.GetField("PropertyType", i).ToString();
                homes.HomeSize = Convert.ToInt32(objDB.GetField("HomeSize", i).ToString());
                homes.Bedrooms = Convert.ToInt32(objDB.GetField("NumBeds", i).ToString());
                homes.Bathrooms = Convert.ToInt32(objDB.GetField("NumBath", i).ToString());
                homes.Amenities = objDB.GetField("Amenities", i).ToString();
                homes.HeatingCooling = objDB.GetField("HeatingCooling", i).ToString();
                homes.YearBuilt = Convert.ToInt32(objDB.GetField("YearBuilt", i).ToString());
                homes.Garage = objDB.GetField("Garage", i).ToString();
                homes.HomeDescription = objDB.GetField("Description", i).ToString();
                homes.AskingPrice = Convert.ToDecimal(objDB.GetField("AskingPrice", i).ToString());
                homeList.Add(homes);
            }
            return homeList;
        }
        [HttpPost("AddAHome")]
        public Boolean AddAHome([FromBody] Home home)
        {
            if (home != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_AddHome";
                objCommand.Parameters.AddWithValue("@theAddress", home.Address);
                objCommand.Parameters.AddWithValue("@theCity", home.City);
                objCommand.Parameters.AddWithValue("@thePropertyType", home.PropertyType);
                objCommand.Parameters.AddWithValue("@theHomeSize", home.HomeSize);
                objCommand.Parameters.AddWithValue("@theNumBeds", home.Bedrooms);
                objCommand.Parameters.AddWithValue("@theNumBaths", home.Bathrooms);
                objCommand.Parameters.AddWithValue("@theAmenities", home.Amenities);
                objCommand.Parameters.AddWithValue("@theHeatingOrCooling", home.HeatingCooling);
                objCommand.Parameters.AddWithValue("@theYearBuilt", home.YearBuilt);
                objCommand.Parameters.AddWithValue("@theGarage", home.Garage);
                objCommand.Parameters.AddWithValue("@theDescription", home.HomeDescription);
                objCommand.Parameters.AddWithValue("@theAskingPrice", home.AskingPrice);
                int returnValue = objDB.DoUpdate(objCommand);
                if (returnValue >= 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        [HttpGet("SearchForHomeByLocationAndPrice/{city}/{minPrice}/{maxPrice}")]
        public List<Home> GetHomesByLocationAndPrice(string city, decimal minPrice, decimal maxPrice)
        {
            List<Home> homeList = new List<Home>();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetHomeByCityAndPrice";
            objCommand.Parameters.AddWithValue("@theCity", city);
            objCommand.Parameters.AddWithValue("@theMinPrice", minPrice);
            objCommand.Parameters.AddWithValue("@theMaxPrice", maxPrice);
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            int count = myDS.Tables[0].Rows.Count;
            for(int i = 0; i < count; i++)
                {
                   Home home = new Home();
                    home.Address = objDB.GetField("Address", i).ToString();
                    home.City = objDB.GetField("City", i).ToString();
                    home.PropertyType = objDB.GetField("PropertyType", i).ToString();
                    home.HomeSize = Convert.ToInt32(objDB.GetField("HomeSize", i).ToString());
                    home.Bedrooms = Convert.ToInt32(objDB.GetField("NumBeds", i).ToString());
                    home.Bathrooms = Convert.ToInt32(objDB.GetField("NumBath", i).ToString());
                    home.Amenities = objDB.GetField("Amenities", i).ToString();
                    home.HeatingCooling = objDB.GetField("HeatingCooling", i).ToString();
                    home.YearBuilt = Convert.ToInt32(objDB.GetField("YearBuilt", i).ToString());
                    home.Garage = objDB.GetField("Garage", i).ToString();
                    home.HomeDescription = objDB.GetField("Description", i).ToString();
                    home.AskingPrice = Convert.ToDecimal(objDB.GetField("AskingPrice", i).ToString());

                homeList.Add(home);
                }
            return homeList;
        }

        [HttpGet("SearchForHomesByLocationPropertyAndPrice/{city}/{propertyType}/{minPrice}/{maxPrice}")]
        public List<Home> GetHomesByLocationPropertyAndPrice(string city, string propertyType, decimal minPrice, decimal maxPrice)
        {
            List<Home> homeList = new List<Home>();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetHomeByLocationPropertyAndPrice";
            objCommand.Parameters.AddWithValue("@theCity", city); 
            objCommand.Parameters.AddWithValue("@thePropertyType", propertyType);
            objCommand.Parameters.AddWithValue("@theMinPrice", minPrice);
            objCommand.Parameters.AddWithValue("@theMaxPrice", maxPrice);
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            int count = myDS.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Home home = new Home();
                home.Address = objDB.GetField("Address", i).ToString();
                home.City = objDB.GetField("City", i).ToString();
                home.PropertyType = objDB.GetField("PropertyType", i).ToString();
                home.HomeSize = Convert.ToInt32(objDB.GetField("HomeSize", i).ToString());
                home.Bedrooms = Convert.ToInt32(objDB.GetField("NumBeds", i).ToString());
                home.Bathrooms = Convert.ToInt32(objDB.GetField("NumBath", i).ToString());
                home.Amenities = objDB.GetField("Amenities", i).ToString();
                home.HeatingCooling = objDB.GetField("HeatingCooling", i).ToString();
                home.YearBuilt = Convert.ToInt32(objDB.GetField("YearBuilt", i).ToString());
                home.Garage = objDB.GetField("Garage", i).ToString();
                home.HomeDescription = objDB.GetField("Description", i).ToString();
                home.AskingPrice = Convert.ToDecimal(objDB.GetField("AskingPrice", i).ToString());

                homeList.Add(home);
            }
            return homeList;
        }

        [HttpGet("SearchForHomesByLocationPricePropertyHouseSizeMinNumBedsAndMinNumBaths/{city}/{minPrice}/{maxPrice}/{propertyType}/{houseSize}/{minNumBeds}/{minNumBaths}")]
        public List<Home> GetHomesByLocation_Price_PropertyType_HomeSize_MinBedrooms_MinBathrooms(string city, decimal minPrice, decimal maxPrice, string propertyType, int minHouseSize, int minNumBeds, int minNumBaths)
        {
            List<Home> homeList = new List<Home>();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetHomeByLocation_Price_Property_HouseSize_MinNumBeds_MinNumBaths";
            objCommand.Parameters.AddWithValue("@theCity", city);
            objCommand.Parameters.AddWithValue("@theMinPrice", minPrice);
            objCommand.Parameters.AddWithValue("@theMaxPrice", maxPrice);
            objCommand.Parameters.AddWithValue("@thePropertyType", propertyType);         
            objCommand.Parameters.AddWithValue("@theMinHouseSize", minHouseSize);
            objCommand.Parameters.AddWithValue("@theMinBedrooms", minNumBeds);
            objCommand.Parameters.AddWithValue("@theMinBathrooms", minNumBaths);
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            int count = myDS.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Home home = new Home();
                home.Address = objDB.GetField("Address", i).ToString();
                home.City = objDB.GetField("City", i).ToString();
                home.PropertyType = objDB.GetField("PropertyType", i).ToString();
                home.HomeSize = Convert.ToInt32(objDB.GetField("HomeSize", i).ToString());
                home.Bedrooms = Convert.ToInt32(objDB.GetField("NumBeds", i).ToString());
                home.Bathrooms = Convert.ToInt32(objDB.GetField("NumBath", i).ToString());
                home.Amenities = objDB.GetField("Amenities", i).ToString();
                home.HeatingCooling = objDB.GetField("HeatingCooling", i).ToString();
                home.YearBuilt = Convert.ToInt32(objDB.GetField("YearBuilt", i).ToString());
                home.Garage = objDB.GetField("Garage", i).ToString();
                home.HomeDescription = objDB.GetField("Description", i).ToString();
                home.AskingPrice = Convert.ToDecimal(objDB.GetField("AskingPrice", i).ToString());

                homeList.Add(home);
            }
            return homeList;
        }

        [HttpDelete("DeleteHomeProfile/{address}")]
        public Boolean DeleteHome(string address)
        {
            try { 
                List<Home> homeList = new List<Home>();
                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_DeleteHomeProfile";
                objCommand.Parameters.AddWithValue("@theAddress", address);
                int returnValue = objDB.DoUpdateUsingCmdObj(objCommand);
                if(returnValue > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                return false;
            }
        }

        [HttpPut("UpdateHomeProfile/{address}")]
        public Boolean UpdateHomeInfo(string address, [FromBody] Home updatedHome)
        {
            List<Home> homeList = new List<Home>();
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateHomeInformation";
            objCommand.Parameters.AddWithValue("@theAddress", address);
            objCommand.Parameters.AddWithValue("@theAskingPrice", updatedHome.AskingPrice);
            objCommand.Parameters.AddWithValue("@theStatus", updatedHome.Status);

            int returnValue = objDB.DoUpdateUsingCmdObj(objCommand);
            if (returnValue > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //List<Home> homeList = new List<Home>();
            //Home home = homeList.Find(h => h.Address.Equals(address));
            //if(home == null)
            //{
            //    return false;
            //}

            //home.City = updatedHome.City;
            //home.PropertyType = updatedHome.PropertyType;
            //home.HomeSize = updatedHome.HomeSize;         
            //home.Amenities = updatedHome.Amenities;
            //home.HeatingCooling = updatedHome.HeatingCooling;
            //home.Garage = updatedHome.Garage;
            //home.HomeDescription = updatedHome.HomeDescription;
        }




    }
}
