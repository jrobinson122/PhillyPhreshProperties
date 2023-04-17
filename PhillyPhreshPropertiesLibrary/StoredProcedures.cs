using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PhillyPhreshPropertiesLibrary
{
    public class StoredProcedures
    {
        //database connection
        DBConnect db = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet dataset = new DataSet();
        User currentUser = new User();

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
        public Boolean AddHouse(string Address, string PropertyType, string HomeSize, string NumBeds, string NumBaths, string Amenities, string HeatingCooling, string YearBuilt, string Garage, string Description, string askingPrice)
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
            objCommand.Parameters.AddWithValue("@theAskingPrice", askingPrice);

            if (objDB.DoUpdateUsingCmdObj(objCommand) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordRecovery(string email)
        {
 
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_ConfirmUser";
                objCommand.Parameters.AddWithValue("theEmail", email);

                dataset = db.GetDataSetUsingCmdObj(objCommand);
                currentUser.SecurityQuestion1= dataset.Tables[0].Rows[0]["SecurityQuestion1"].ToString();
                currentUser.Answer1 = dataset.Tables[0].Rows[0]["Answer1"].ToString();
                currentUser.SecurityQuestion2 = dataset.Tables[0].Rows[0]["SecurityQuestion2"].ToString();
                currentUser.Answer2 = dataset.Tables[0].Rows[0]["Answer2"].ToString();
                currentUser.SecurityQuestion3 = dataset.Tables[0].Rows[0]["SecurityQuestion3"].ToString();
                currentUser.Answer3 = dataset.Tables[0].Rows[0]["Answer3"].ToString();
                currentUser.Password = dataset.Tables[0].Rows[0]["Password"].ToString();


                objCommand.Parameters.Clear();

                return true;
            }
            catch
            {
                return false;
            }
        }//end PasswordRecovery()

        //method returns true if user has been found and false if user is not found or error occurred
        public bool GetUser(string email, string password)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetUser";
                objCommand.Parameters.AddWithValue("theEmail", email);
                objCommand.Parameters.AddWithValue("thePassword", password);

                dataset = db.GetDataSetUsingCmdObj(objCommand);
                currentUser.Email = dataset.Tables[0].Rows[0]["Email"].ToString();
                currentUser.Password = dataset.Tables[0].Rows[0]["Password"].ToString();
                currentUser.FirstName = dataset.Tables[0].Rows[0]["FirstName"].ToString();
                currentUser.LastName = dataset.Tables[0].Rows[0]["LastName"].ToString();
                //wait before finishing
                //how are we sending user data to each page

                objCommand.Parameters.Clear();

                return true;
            }
            catch
            {
                return false;
            }
        }// end GetUser()
    }
}


