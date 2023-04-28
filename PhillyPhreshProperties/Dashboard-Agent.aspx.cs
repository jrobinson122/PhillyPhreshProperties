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
    public partial class Dashboard_Agent : System.Web.UI.Page
    {
        User agent = new User();
        StoredProcedures procedure = new StoredProcedures();
        string email;
        string type;
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();

        protected void Page_Load(object sender, EventArgs e)
        {
            byte[] emailData = (byte[])Session["Email"];
            stream = new MemoryStream(emailData);
            email = (string)formatter.Deserialize(stream);

            byte[] typeData = (byte[])Session["AccountType"];
            stream = new MemoryStream(typeData);
            type = (string)formatter.Deserialize(stream);

            agent = procedure.LoadUser(email, type);

            //call SOAP service here to load gvHomes
            DashboardSrvc.Dashboard prxyDashboard = new DashboardSrvc.Dashboard();


            gvHomes.DataSource = prxyDashboard.LoadHouses();
            gvHomes.DataBind();

            gvReviews.DataSource = prxyDashboard.LoadReviews();
            gvReviews.DataBind();
        }

        protected void btnShowing_Click(object sender, EventArgs e)
        {
            //save agent name and city to session obj
            Response.Redirect("Showing-Agent.aspx");
        }

        protected void gvHomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gvHomes.SelectedRow.Cells[0].Text; //send the homeID of the selected house and the agent email, maybe?, to the manage home profile page
        }
    }
}