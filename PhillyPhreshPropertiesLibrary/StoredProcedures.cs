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
            if (objDB.DoUpdateUsingCmdObj(objCommand) > 0){
                return true;
            }
            return false;
        }
        //public Boolean AddSecurityQuestions(/*string Email, */string Question1, string Answer1, string Question2, string Answer2, string Question3, string Answer3)
        //{
        //    DBConnect objDB = new DBConnect();
        //    SqlCommand objCommand = new SqlCommand();
        //    objCommand.CommandType = CommandType.StoredProcedure;
        //    objCommand.CommandText = "TP_AddSecurityQuestions";
        //    //objCommand.Parameters.AddWithValue("@theEmail", Email);
        //    objCommand.Parameters.AddWithValue("@theSecurityQuestion1", Question1);
        //    objCommand.Parameters.AddWithValue("@theSecurityAnswer1", Answer1);
        //    objCommand.Parameters.AddWithValue("@theSecurityQuestion2", Question2);
        //    objCommand.Parameters.AddWithValue("@theSecurityAnswer2", Answer2);
        //    objCommand.Parameters.AddWithValue("@theSecurityQuestion3", Question3);
        //    objCommand.Parameters.AddWithValue("@theSecurityAnswer3", Answer3);
        //    if(objDB.DoUpdateUsingCmdObj(objCommand) > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false; 
        //    }
        }
    }


