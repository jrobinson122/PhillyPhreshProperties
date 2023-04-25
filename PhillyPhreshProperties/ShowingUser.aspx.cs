using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;

namespace PhillyPhreshProperties
{
    public partial class ShowingUser : System.Web.UI.Page
    {
        StoredProcedures procedure = new StoredProcedures();
        User user = new User();
        private bool success= false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //use email passed in from session obj
                rptShowings.DataSource = procedure.LoadBuyerShowings("testUser1@gmail.com");
                rptShowings.DataBind();
            }
            //use ajax to update just the repeater event though that might be too simple for him
            
        }

        protected void btnSchedule_Click(object sender, EventArgs e)
        {
            DateTime date= DateTime.Today;
            string time= "";
            string agent;
            string buyer;
            string email;

            Validation();

            if (!lblError.Visible)
            {
                if(ddlDate.SelectedValue == "1")
                {
                    date = DateTime.Today.AddDays(1).Date;
                }
                else if(ddlDate.SelectedValue == "2")
                {
                    date = DateTime.Today.AddDays(2).Date;
                }
                else if(ddlDate.SelectedValue == "3")
                {
                    date = DateTime.Today.AddDays(3).Date;
                }
                else if (ddlDate.SelectedValue == "4")
                {
                    date = DateTime.Today.AddDays(4).Date;
                }
                else if (ddlDate.SelectedValue == "5")
                {
                    date = DateTime.Today.AddDays(5).Date;
                }
                else if (ddlDate.SelectedValue == "6")
                {
                    date = DateTime.Today.AddDays(7).Date;
                }

                if(ddlTime.SelectedValue == "1")
                {
                    time = ddlTime.Text;
                }
                else if (ddlTime.SelectedValue == "2")
                {
                    time = ddlTime.Text;
                }
                else if(ddlTime.SelectedValue == "3")
                {
                    time = ddlTime.Text;
                }
                else if(ddlTime.SelectedValue == "4")
                {
                    time = ddlTime.Text;
                }
                else if(ddlTime.SelectedValue == "5")
                {
                    time = ddlTime.Text;
                }
                else if(ddlTime.SelectedValue == "6")
                {
                    time = ddlTime.Text;
                }

                agent= procedure.GetAgent(txtCity.Text).FirstName + procedure.GetAgent(txtCity.Text).LastName;
                //get email and buyer name from session
                success= procedure.AddShowing(email, buyer, agent, txtAddress.Text, txtCity.Text,time, date);

                if(success)
                {
                    procedure.AddShowing(email, buyer, agent, txtAddress.Text, txtCity.Text, time, date);
                }
                else
                {
                    InputError("The showing was not scheduled");
                }
            }
            
            
        }

        private void Validation()
        {
            if (txtAddress.Text == "")
            {
                InputError("Please enter an address above");
            }
            else if (txtCity.Text == "")
            {
                InputError("Please enter a city for the address above");
            }
            else if(ddlDate.SelectedValue == "0")
            {
                InputError("Please select a date for the showing");
            }
            else if(ddlTime.SelectedValue == "0")
            {
                InputError("Please select a time for the showing");
            }
            else
            {
                lblError.Text = "";
                lblError.Visible = false;
            }
        }//end Validation()

        public void InputError(string error)
        {
            lblError.Text = error;
            lblError.Visible = true;
        }//end InputError()
    }
}