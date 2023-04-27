using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace PhillyPhreshProperties
{
    public partial class AccountRegistration : System.Web.UI.Page
    {
        StoredProcedures procedures = new StoredProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string email = "";
            string password = "";
            string firstname = "";
            string lastname = "";
            string address = "";
            string city = "";
            string state = "";
            string zipcode = "";
            string phoneNumber = "";
            string accountType = ddlAccountType.SelectedValue;
            string securityQuestion1 = ddlSecurityQuestion1.SelectedValue;
            string answer1 = "";
            string securityQuestion2 = ddlSecurityQuestion2.SelectedValue;
            string answer2 = "";
            string securityQuestion3 = ddlSecurityQuestion3.SelectedValue;
            string answer3 = "";
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtRegisterEmail.Text))
            {
                lblMessage.Text += "Please enter an email. </br>";
                flag = false;
            }
            else
            {
                email = txtRegisterEmail.Text;
            }


            if (string.IsNullOrWhiteSpace(txtRegisterPassword.Text))
            {
                lblMessage.Text += "Please enter an password. </br>";
                flag = false;
            }
            else
            {
                password = txtRegisterPassword.Text;
            }


            if (string.IsNullOrWhiteSpace(txtRegisterFirstName.Text))
            {
                lblMessage.Text += "Please enter your first name. </br>";
                flag = false;
            }
            else if (txtRegisterFirstName.Text.All(Char.IsLetter) == false)
            {
                lblMessage.Text += "First name must only be letters. </br>";
            }
            else
            {
                firstname = txtRegisterFirstName.Text;
            }


            if (string.IsNullOrWhiteSpace(txtRegisterLastName.Text))
            {
                lblMessage.Text += "Please enter your last name. </br>";
                flag = false;
            }
            else if (txtRegisterLastName.Text.All(Char.IsLetter) == false)
            {
                lblMessage.Text += "Last name must only be letters. </br>";
            }
            else
            {
                lastname = txtRegisterLastName.Text;
            }


            if (string.IsNullOrWhiteSpace(txtRegisterAddress.Text))
            {
                lblMessage.Text += "Please enter your address. </br>";
                flag = false;
            }
            else
            {
                address = txtRegisterAddress.Text;
            }


            if (string.IsNullOrWhiteSpace(txtRegisterCity.Text))
            {
                lblMessage.Text += "Please enter your city. </br>";
                flag = false;
            }
            else
            {
                city = txtRegisterCity.Text;
            }


            //if (string.IsNullOrWhiteSpace(txtRegisterState.Text))
            //{
            //    lblMessage.Text += "Please enter your last name. </br>";
            //    flag = false;
            //}
            //else if (txtRegisterState.Text.Length != 2)
            //{
            //    lblMessage.Text += "Please enter a valid state. </br";
            //}
            //else
            //{
            //    state = txtRegisterState.Text;
            //}


            if (string.IsNullOrWhiteSpace(txtRegisterZipCode.Text))
            {
                lblMessage.Text += "Please enter your zip code. </br>";
                flag = false;
            }
            else if (txtRegisterZipCode.Text.Length != 5)
            {
                lblMessage.Text += "Zip code must be 5 digits long. </br>";
                flag = false;
            }
            else if (txtRegisterZipCode.Text.All(char.IsDigit) == false)
            {
                lblMessage.Text += "Zip code must only be integers. </br>";
                flag = false;
            }
            else
            {
                zipcode = txtRegisterZipCode.Text;
            }


            if (string.IsNullOrWhiteSpace(txtRegisterPhoneNumber.Text))
            {
                lblMessage.Text += "Please enter your last name. </br>";
                flag = false;
            }
            else if (txtRegisterPhoneNumber.Text.Length != 10)
            {
                lblMessage.Text += "Phone number must be 10 digits. </br>";
                flag = false;
            }
            else if (txtRegisterPhoneNumber.Text.All(Char.IsDigit) == false)
            {
                lblMessage.Text += "Phone number must only be digits </br>";
                flag = false;
            }
            else
            {
                phoneNumber = txtRegisterPhoneNumber.Text;
            }

            if (String.IsNullOrWhiteSpace(txtSecurityAnswer1.Text))
            {
                lblMessage.Text += "Please fill out the first security question. </br>";
                flag = false;
            }
            else
            {
                answer1 = txtSecurityAnswer1.Text;
            }
            if (String.IsNullOrWhiteSpace(txtSecurityAnswer2.Text))
            {
                lblMessage.Text += "Please fill out the second security question. </br>";
                flag = false;
            }
            else
            {
                answer2 = txtSecurityAnswer2.Text;
            }
            if (String.IsNullOrWhiteSpace(txtSecurityAnswer3.Text))
            {
                lblMessage.Text += "Please fill out the third security question. </br>";
                flag = false;
            }
            else
            {
                answer3 = txtSecurityAnswer3.Text;
            }

            if (flag == true)
            {
                //if (chkRemmeberMe.Checked)
                //{
                //    HttpCookie loginIDCookie = new HttpCookie("LoginID");
                //    loginIDCookie.Value = email;
                //    loginIDCookie.Expires = DateTime.Now.AddDays(7);
                //    Response.Cookies.Add(loginIDCookie);
                //}

                if (procedures.AddUser(email, password, firstname, lastname, address, city, state, zipcode, phoneNumber, accountType, securityQuestion1, answer1, securityQuestion2, answer2, securityQuestion3, answer3) == true)
                {
                    lblMessage.Text += "New user added to Philly Phresh Properties!";
                    Response.Redirect("Verification.aspx");
                }
                else
                {
                    lblMessage.Text += "error adding new user to Philly Phresh Properties.";
                }
            }
        }
    }
}