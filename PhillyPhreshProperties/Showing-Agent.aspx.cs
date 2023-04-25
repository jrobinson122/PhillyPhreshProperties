using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;

namespace PhillyPhreshProperties
{
    public partial class Showing_Agent : System.Web.UI.Page
    {
        StoredProcedures procedure = new StoredProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Set the datasource of the Repeater control and bind the data
                rptShowings.DataSource = procedure.LoadAgentShowings("Max Goof");  //i need to send the customer email and the agent name as arguments;
                rptShowings.DataBind();
            }

        }

        
    }
}