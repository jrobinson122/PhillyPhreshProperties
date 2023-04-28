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
    public partial class Showings_Agent : System.Web.UI.Page
    {
        StoredProcedures procedure = new StoredProcedures();
        User agent = new User();
        string email;
        string type;
        BinaryFormatter formatter = new BinaryFormatter();
        MemoryStream stream = new MemoryStream();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                byte[] emailData = (byte[])Session["Email"];
                stream = new MemoryStream(emailData);
                email = (string)formatter.Deserialize(stream);

                byte[] typeData = (byte[])Session["AccountType"];
                stream = new MemoryStream(typeData);
                type = (string)formatter.Deserialize(stream);

                agent = procedure.LoadUser(email, type);
                string name = agent.FirstName + " " + agent.LastName;

                rptShowings.DataSource = procedure.LoadAgentShowings("Max Goof");// send name here
                rptShowings.DataBind();
            }

        }

        
    }
}