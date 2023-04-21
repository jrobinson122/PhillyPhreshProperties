﻿using System;
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


    }//end User class

    }
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PhillyPhreshPropertiesLibrary
//{
//    class User
//    {
//        string email;
//        string password;
//        string firstName;
//        string lastName;
//        string address;
//        string city;
//        string state;
//        string zip;
//        string phoneNumber;


//        public User()
//        {

//        }


//        public string Email
//        {
//            get { return email; }
//            set { email = value; }
//        }
//        public string Password
//        {
//            get { return password; }
//            set { password = value; }
//        }
//        public string FirstName
//        {
//            get { return firstName; }
//            set { firstName = value; }
//        }
//        public string LastName
//        {
//            get { return lastName; }
//            set { lastName = value; }
//        }
//        public string Address
//        {
//            get { return address; }
//            set { address = value; }
//        }
//        public string City
//        {
//            get { return city; }
//            set { city = value; }
//        }
//        public string State
//        {
//            get { return state; }
//            set { state = value; }
//        }
//        public string Zip
//        {
//            get { return zip; }
//            set { zip = value; }
//        }
//        public string PhoneNumber
//        {
//            get { return phoneNumber; }
//            set { phoneNumber = value; }
//        }
//    }

}

 