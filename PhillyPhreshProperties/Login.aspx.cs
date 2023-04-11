using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;

namespace PhillyPhreshProperties
{
    public partial class Login : System.Web.UI.Page
    {
        User user = new User();

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
                user.GetUser();
                Response.Redirect("LandingPage.aspx");
            }

            //need a check for if chkSaveLoginInfo is checked
            //
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
                user.PasswordRecovery();

                if (!user.PasswordRecovery())
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