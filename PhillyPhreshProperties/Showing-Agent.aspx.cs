using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhillyPhreshProperties
{
    public partial class Showing_Agent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the datasource of the Repeater control and bind the data
                //rptShowings.DataSource = //dataset returned from stored procedure goes here;
                //rptShowings.DataBind();
            }

        }

        
    }
}