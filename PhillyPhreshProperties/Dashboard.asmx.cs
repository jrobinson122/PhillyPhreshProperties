using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PhillyPhreshPropertiesLibrary;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace PhillyPhreshProperties
{
    /// <summary>
    /// Summary description for Dashboard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Dashboard : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet LoadHouses()
        {

            //database connection
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            DataSet dataset = new DataSet();
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetAllHomes";

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);

                return dataset;
            }
            catch
            {
                return null;
            }
        }//end LoadHouses()

        [WebMethod]
        public DataSet LoadReviews()
        {
            //database connection
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            DataSet dataset = new DataSet();
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadReviews";

                dataset = objDB.GetDataSetUsingCmdObj(objCommand);

                return dataset;
            }
            catch
            {
                return null;
            }
        }

    }//end Dashboard class
}
