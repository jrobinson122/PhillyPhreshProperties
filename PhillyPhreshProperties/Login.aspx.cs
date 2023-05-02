using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PhillyPhreshProperties
{
    public partial class Login : System.Web.UI.Page
    {
        User user = new User();
        StoredProcedures procedure = new StoredProcedures();
        string email;
        string type;
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountRegistration.aspx");

        }//end btnRegister_Click()

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Validation();

            if (!lblError.Visible)
            {
                user= procedure.GetUser(txtEmail.Text, txtPassword.Text);

                if(user != null)
                {
                    email = user.Email;
                    type = user.AccountType;

                    formatter.Serialize(stream, email);
                    formatter.Serialize(stream, type);

                    byte[] emailData = stream.ToArray();
                    Session["User"] = emailData;

                    if (chkSaveLoginInfo.Checked)
                    {
                        Response.Cookies["authUserCookie"]["email"] = user.Email;
                        Response.Cookies["authUserCookie"]["password"] = user.Password;
                    }

                    if(user.AccountType == "Buyer")
                    {
                        Response.Redirect("Showings-Buyer.aspx");
                    }
                    else if(user.AccountType == "Agent" || user.AccountType == "Seller")
                    {
                        Response.Redirect("Dashboard-Agent.aspx");
                    }
                    
                }
                
            }

        }//end btnLogin_Click()

        protected void btnForgot_Click(object sender, EventArgs e)
        {
            user.Email = txtEmail.Text;

            if(txtEmail.Text == "")
            {
                InputError("Please enter your email above first then click Forgot Password again.");
            }
            else
            {
                lblError.Visible = false;
                user= procedure.PasswordRecovery(txtEmail.Text);

                if (user == null)
                {
                    InputError("Your account was not found. Please check email for spelling errors and try agian.");
                }
                else
                {
                    SecurityQuestion();
                }                
            }

        }//end btnForgot_Click()

        protected void btnConfirmRecovery_Click(object sender, EventArgs e)
        {
            user.CheckSecurityAnswer(txtRecoveryAnswer.Text);

            if (user.CheckSecurityAnswer(txtRecoveryAnswer.Text))
            {
                lblRecoveredPassword.Text = "Your password is " + user.Password;
                lblError.Visible = false;
            }
            else
            {
                InputError("That answer is inccorect please try again.");
            }
        }

        private void Validation()
        {
            if (txtEmail.Text == "")
            {
                InputError("Please enter your email above");
            }
            else if (txtPassword.Text == "")
            {
                InputError("Please enter your password above");
            }
            else
            {
                lblError.Text = "";
            }
        }//end Validation()

        private void SecurityQuestion()
        {
            Random number = new Random();
            int question = number.Next(1, 4); //generates random number between 1 and 3

            switch (question)
            {
                case 1:
                    lblRecoveyQuestion.Text = user.SecurityQuestion1;
                    break;
                case 2:
                    lblRecoveyQuestion.Text = user.SecurityQuestion2;
                    break;
                case 3:
                    lblRecoveyQuestion.Text = user.SecurityQuestion3;
                    break;
            }

            lblRecoveyQuestion.Visible = true;
            txtRecoveryAnswer.Visible = true;
            btnConfirmRecovery.Visible = true;
        }//end SecurityQuestion

        public void InputError(string error)
        {
            lblError.Text = error;
            lblError.Visible = true;
        }//end InputError()

    }//end Login class
}