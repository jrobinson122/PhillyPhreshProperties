using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhillyPhreshProperties
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //need a check for if chkSaveLoginInfo is checked
            //
        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {

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

        public void InputError(string error)
        {
            lblError.Text = error;
            lblError.Visible = true;
        }//end InputError()

        
    }//end Login class
}