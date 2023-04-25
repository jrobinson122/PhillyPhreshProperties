using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace PhillyPhreshPropertiesLibrary
{
    public class User
    {
        private string userID;
        private string email = "";
        private string password = "";
        private string firstname = "";
        private string lastname = "";
        private string address = "";
        private string city = "";
        private string state = "";
        private int zipcode = 0;
        private int phoneNumber = 0;
        private string accountType = "";
        private string securityQuestion1 = "";
        private string answer1 = "";
        private string securityQuestion2 = "";
        private string answer2 = "";
        private string securityQuestion3 = "";
        private string answer3 = "";
        public bool isVerified;

        //database connection
        DBConnect db = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet dataset = new DataSet();

        //default constructor
        public User() { }

        public User(string email, string password, string firstName, string lastName, string address, string city, string state, int zipcode, int phoneNumber, string accountType, string securityQuestion1, string answer1, string securityQuestion2, string answer2, string securityQuestion3, string answer3)
        {
            this.email = email;
            this.password = password;
            this.firstname = firstName;
            this.lastname = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.accountType = accountType;
            this.securityQuestion1 = securityQuestion1;
            this.answer1 = answer1;
            this.securityQuestion2 = securityQuestion2;
            this.answer2 = answer2;
            this.securityQuestion3 = securityQuestion3;
            this.answer3 = answer3;
        }

        //method returns true if user has been found and false if user is not found or error occurred
        public bool GetUser()
        {
            /*
             CREATE PROCEDURE [dbo].TP_GetUser
	            @theEmail VARCHAR(MAX),
	            @thePassword VARCHAR(MAX)
            AS
	            SELECT * FROM TP_User WHERE Email= @theEmail and Password= @thePassword
            RETURN 0
             */
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetUser";
                objCommand.Parameters.AddWithValue("theEmail", email);
                objCommand.Parameters.AddWithValue("thePassword", password);

                dataset = db.GetDataSetUsingCmdObj(objCommand);
                userID = dataset.Tables[0].Rows[0]["UserId"].ToString();
                email = dataset.Tables[0].Rows[0]["Email"].ToString();
                password = dataset.Tables[0].Rows[0]["Password"].ToString();
                firstname = dataset.Tables[0].Rows[0]["FirstName"].ToString();
                lastname = dataset.Tables[0].Rows[0]["LastName"].ToString();
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

        public bool PasswordRecovery()
        {
            /*
             CREATE PROCEDURE [dbo].TP_GetQuestions
	            @theEmail VARCHAR(MAX)
            AS
	            SELECT * FROM TP_User WHERE Email= @theEmail
            RETURN 0
             */
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_ConfirmUser";
                objCommand.Parameters.AddWithValue("theEmail", email);

                dataset = db.GetDataSetUsingCmdObj(objCommand);
                securityQuestion1 = dataset.Tables[0].Rows[0]["SecurityQuestion1"].ToString();
                answer1 = dataset.Tables[0].Rows[0]["Answer1"].ToString();
                securityQuestion2 = dataset.Tables[0].Rows[0]["SecurityQuestion2"].ToString();
                answer2 = dataset.Tables[0].Rows[0]["Answer2"].ToString();
                securityQuestion3 = dataset.Tables[0].Rows[0]["SecurityQuestion3"].ToString();
                answer3 = dataset.Tables[0].Rows[0]["Answer3"].ToString();
                password = dataset.Tables[0].Rows[0]["Password"].ToString();


                objCommand.Parameters.Clear();

                return true;
            }
            catch
            {
                return false;
            }
        }//end PasswordRecovery()

        public bool CheckSecurityAnswer(string answer)
        {


            if (answer.CompareTo(answer1) == 0)
            {
                return true;
            }
            else if (answer.CompareTo(answer2) == 0)
            {
                return true;
            }
            else if (answer.CompareTo(answer3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }//end CheckSecurityAnswer()

        //getters and setters
        public string UserID
        { get { return userID; } set { userID = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public string Password
        { get { return password; } set { password = value; } }

        public string FirstName
        { get { return firstname; } set { firstname = value; } }

        public string LastName
        { get { return lastname; } set { lastname = value; } }

        public string Address
        { get { return address; } set { address = value; } }

        public string City
        { get { return city; } set { city = value; } }

        public string State
        { get { return state; } set { state = value; } }

        public int Zipcode
        { get { return zipcode; } set { zipcode = value; } }

        public int PhoneNumber
        { get { return phoneNumber; } set { phoneNumber = value; } }

        public string AccountType
        { get { return accountType; } set { accountType = value; } }

        public string SecurityQuestion1
        { get { return securityQuestion1; } set { securityQuestion1 = value; } }

        public string Answer1
        { get { return answer1; } set { answer1 = value; } }

        public string SecurityQuestion2
        { get { return securityQuestion2; } set { securityQuestion2 = value; } }

        public string Answer2
        { get { return answer2; } set { answer2 = value; } }

        public string SecurityQuestion3
        { get { return securityQuestion3; } set { securityQuestion3 = value; } }

        public string Answer3
        { get { return answer3; } set { answer3 = value; } }

    }
}