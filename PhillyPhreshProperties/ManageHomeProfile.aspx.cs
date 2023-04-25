using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;

namespace PhillyPhreshProperties
{
    public partial class ManageHomeProfile : System.Web.UI.Page
    {
        String webApiUrl = "http://localhost:57085/api/Properties/";
        private List<Home> homeList = new List<Home>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            gvHomes.DataSource = homeList;
            gvHomes.DataBind();
        }

        protected void gvHomes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvHomes.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void gvHomes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvHomes.Rows[e.RowIndex];
            string address = (gvHomes.DataKeys[e.RowIndex].Value).ToString();
            TextBox txtPrice = row.FindControl("txtAskingPrice") as TextBox;
            DropDownList ddlStatus = row.FindControl("ddlStatus") as DropDownList;
        }

        protected void gvHomes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}