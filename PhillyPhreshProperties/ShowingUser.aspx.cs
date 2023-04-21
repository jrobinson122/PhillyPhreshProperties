using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhillyPhreshProperties
{
    public partial class Showing_User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSchedule_Click(object sender, EventArgs e)
        {
            /*
             CREATE PROCEDURE [dbo].TP_AddShowing
	            @theEmail VARCHAR(MAX),
                @theBuyer VARCHAR(MAX),
                @theAgent VARCHAR(MAX),
                @theAddress VARCHAR(MAX),
                @theDate DATETIME,
                @theTime VARCHAR(50)
            AS
	            INSERT INTO TP_Showings (Email, Buyer, Agent, Address, Date, Time)
                VALUES (@theEmail, @theBuyer, @theAgent, @theAddress, @theDate, @theTime)
            RETURN 0
             */
        }
    }
}