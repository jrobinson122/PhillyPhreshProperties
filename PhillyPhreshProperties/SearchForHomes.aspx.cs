using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace PhillyPhreshProperties
{
    public partial class SearchForHomes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "ShowHomes";
            gvHomes.DataSource = objDB.GetDataSetUsingCmdObj(objCommand);
            gvHomes.DataBind();
        }
    }
}