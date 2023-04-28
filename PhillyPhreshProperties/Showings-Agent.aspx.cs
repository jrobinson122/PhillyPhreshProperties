using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;

namespace PhillyPhreshProperties
{
    public partial class Showings_Agent : System.Web.UI.Page
    {
        StoredProcedures procedure = new StoredProcedures();
        User agent = new User();
        string email;
        string type;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //email = Session["Email"].ToString();
                //type = Session["AccountType"].ToString();
                //agent = procedure.LoadUser(email, type);
                //string name = agent.FirstName + " " + agent.LastName;

                rptShowings.DataSource = procedure.LoadAgentShowings("Max Goof");
                rptShowings.DataBind();
            }

        }

        
    }
}