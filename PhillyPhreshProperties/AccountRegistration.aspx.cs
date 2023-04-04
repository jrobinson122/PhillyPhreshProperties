using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhillyPhreshProperties
{
    public partial class AccountRegistration : System.Web.UI.Page
    {
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
            else if(txtRegisterFirstName.Text.All(Char.IsLetter) == false)
            {
                lblMessage.Text += "First name must only be letters. </br>";
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
            if (string.IsNullOrWhiteSpace(txtRegisterAddress.Text))
            {
                lblMessage.Text += "Please enter your address. </br>";
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(txtRegisterCity.Text))
            {
                lblMessage.Text += "Please enter your city. </br>";
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(txtRegisterState.Text))
            {
                lblMessage.Text += "Please enter your last name. </br>";
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(txtRegisterLastName.Text))
            {
                lblMessage.Text += "Please enter your last name. </br>";
                flag = false;
            }
        }
    }
}