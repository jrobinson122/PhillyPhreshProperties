using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Globalization;

namespace PhillyPhreshPropertiesLibrary
{
    public class StoredProcedures
    {
        //database connection
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet dataset = new DataSet();
       

        public Boolean AddUser(string Email, string Password, string FirstName, string LastName, string Address, string City, string State, string Zipcode, string PhoneNumber, string Question1, string Answer1, string Question2, string Answer2, string Question3, string Answer3)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddUser";
            objCommand.Parameters.AddWithValue("@theEmail", Email);
            objCommand.Parameters.AddWithValue("@thePassword", Password);
            objCommand.Parameters.AddWithValue("@theFirstName", FirstName);
            objCommand.Parameters.AddWithValue("@theLastName", LastName);
            objCommand.Parameters.AddWithValue("@theAddress", Address);
            objCommand.Parameters.AddWithValue("@theCity", City);
            objCommand.Parameters.AddWithValue("@theState", State);
            objCommand.Parameters.AddWithValue("@theZipcode", Zipcode);
            objCommand.Parameters.AddWithValue("@thePhoneNumber", PhoneNumber);
            objCommand.Parameters.AddWithValue("@theSecurityQuestion1", Question1);
            objCommand.Parameters.AddWithValue("@theSecurityAnswer1", Answer1);
            objCommand.Parameters.AddWithValue("@theSecurityQuestion2", Question2);
            objCommand.Parameters.AddWithValue("@theSecurityAnswer2", Answer2);
            objCommand.Parameters.AddWithValue("@theSecurityQuestion3", Question3);
            objCommand.Parameters.AddWithValue("@theSecurityAnswer3", Answer3);
            if (objDB.DoUpdateUsingCmdObj(objCommand) > 0)
            {
                return true;
            }
            return false;
        }
        public Boolean AddHouse(string Address, string PropertyType, string HomeSize, string NumBeds, string NumBaths, string Amenities, string HeatingCooling, string YearBuilt, string Garage, string Description, string AskingPrice)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddHome";
            objCommand.Parameters.AddWithValue("@theAddress", Address);
            objCommand.Parameters.AddWithValue("@thePropertyType", PropertyType);
            objCommand.Parameters.AddWithValue("@theHomeSize", HomeSize);
            objCommand.Parameters.AddWithValue("@theNumBeds", NumBeds);
            objCommand.Parameters.AddWithValue("@theNumBaths", NumBaths);
            objCommand.Parameters.AddWithValue("@TheAmenities", Amenities);
            objCommand.Parameters.AddWithValue("@TheHeatingOrCooling", HeatingCooling);
            objCommand.Parameters.AddWithValue("@TheYearBuilt", YearBuilt);
            objCommand.Parameters.AddWithValue("@theGarage", Garage);
            objCommand.Parameters.AddWithValue("@theDescription", Description);
            objCommand.Parameters.AddWithValue("@theAskingPrice", AskingPrice);

            if (objDB.DoUpdateUsingCmdObj(objCommand) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUser(string email, string password)
        {
            User currentUser = new User();
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetUser";
                objCommand.Parameters.AddWithValue("@theEmail", email);
                objCommand.Parameters.AddWithValue("@thePassword", password);

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);
                currentUser.Email = dataset.Tables[0].Rows[0]["Email"].ToString();
                currentUser.Password = dataset.Tables[0].Rows[0]["Password"].ToString();
                currentUser.AccountType= dataset.Tables[0].Rows[0]["AccountType"].ToString();

                objCommand.Parameters.Clear();

                return currentUser;
            }
            catch
            {
                return null;
            }
        }// end GetUser()

        public User LoadUser(string email, string type)
        {
            User currentUser = new User();
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadUser";
                objCommand.Parameters.AddWithValue("@theEmail", email);
                objCommand.Parameters.AddWithValue("@theType", type);

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);
                currentUser.Email = dataset.Tables[0].Rows[0]["Email"].ToString();
                currentUser.FirstName = dataset.Tables[0].Rows[0]["FirstName"].ToString();
                currentUser.LastName = dataset.Tables[0].Rows[0]["LastName"].ToString();
                currentUser.Address = dataset.Tables[0].Rows[0]["Address"].ToString();
                currentUser.PhoneNumber = Int32.Parse(dataset.Tables[0].Rows[0]["PhoneNumber"].ToString());
                currentUser.City = dataset.Tables[0].Rows[0]["City"].ToString();
                currentUser.State = dataset.Tables[0].Rows[0]["State"].ToString();
                currentUser.Zipcode = Int32.Parse(dataset.Tables[0].Rows[0]["Zipcode"].ToString());

                objCommand.Parameters.Clear();

                return currentUser;
            }
            catch
            {
                return null;
            }
        }

        public User PasswordRecovery(string email)
        {
            User currentUser = new User();
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_ConfirmUser";
                objCommand.Parameters.AddWithValue("@theEmail", email);

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);
                currentUser.SecurityQuestion1= dataset.Tables[0].Rows[0]["SecurityQuestion1"].ToString();
                currentUser.Answer1 = dataset.Tables[0].Rows[0]["Answer1"].ToString();
                currentUser.SecurityQuestion2 = dataset.Tables[0].Rows[0]["SecurityQuestion2"].ToString();
                currentUser.Answer2 = dataset.Tables[0].Rows[0]["Answer2"].ToString();
                currentUser.SecurityQuestion3 = dataset.Tables[0].Rows[0]["SecurityQuestion3"].ToString();
                currentUser.Answer3 = dataset.Tables[0].Rows[0]["Answer3"].ToString();
                currentUser.Password = dataset.Tables[0].Rows[0]["Password"].ToString();


                objCommand.Parameters.Clear();

                return currentUser;
            }
            catch
            {
                return null;
            }
        }//end PasswordRecovery()

        public bool AddShowing(string email, string buyer, string agent, string address, string city, string time, DateTime date)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_AddShowing";

                objCommand.Parameters.AddWithValue("@theEmail", email);
                objCommand.Parameters.AddWithValue("@theBuyer", buyer);
                objCommand.Parameters.AddWithValue("@theAgent", agent);
                objCommand.Parameters.AddWithValue("@theAddress", address);
                objCommand.Parameters.AddWithValue("@theCity", city);
                objCommand.Parameters.AddWithValue("@theDate", date);
                objCommand.Parameters.AddWithValue("@theTime", time);

                objDB.DoUpdate(objCommand);
                objCommand.Parameters.Clear();

                return true;
            }
            catch
            {
                return false;
            }
        }//end AddShowing()

        public ArrayList LoadBuyerShowings(string email)
        {
            ArrayList showingsList = new ArrayList();
            Showings showing= new Showings();
            var dateInfo = new CultureInfo("en-US");
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadBuyerShowings";
                objCommand.Parameters.AddWithValue("@theEmail", email);

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    showing = new Showings {
                        Agent= row["Agent"].ToString(), 
                        Address= row["Address"].ToString(), 
                        City= row["City"].ToString(), 
                        Time= row["Time"].ToString(), 
                        Date= DateTime.ParseExact(row["Date"].ToString(), "d", dateInfo)
                    };

                    showingsList.Add(showing);
                }

                objCommand.Parameters.Clear();

                return showingsList;
            }
            catch
            {
                return null;
            }
        }//end LoadBuyerShowings()

        public DataSet LoadAgentShowings(string agent)
        {
            //i thought i needed the city to send to the agent rpt
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadAgentShowings";
                objCommand.Parameters.AddWithValue("@theAgent", agent);

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);

                objCommand.Parameters.Clear();

                return dataset;
            }
            catch
            {
                return null;
            }
        }//end LoadAgentShowings

        public User GetAgent(string city)
        {
            User agent = new User();
           
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetAgent";
                objCommand.Parameters.AddWithValue("@theCity", city);
                objCommand.Parameters.AddWithValue("@theType", "Agent");

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);
                agent.FirstName = dataset.Tables[0].Rows[0]["FirstName"].ToString();
                agent.LastName = dataset.Tables[0].Rows[0]["LastName"].ToString();

                objCommand.Parameters.Clear();

                return agent;
            }
            catch
            {
                return null;
            }
        }//end GetAgent()
    }
}


