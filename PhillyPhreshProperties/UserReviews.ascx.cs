using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhillyPhreshPropertiesLibrary;

namespace PhillyPhreshProperties
{
    public partial class UserReviews : System.Web.UI.UserControl
    {
        public delegate void ReviewSubmittedEventHandler(object sender, Reviews e);

        public event ReviewSubmittedEventHandler ReviewSubmitted;

        protected virtual void OnReviewSubmitted(Reviews e)
        {
            ReviewSubmitted?.Invoke(this, e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string reviewerName = txtReviewerName.Value;
            int rating = Convert.ToInt32(ddlRating.SelectedValue);
            string reviewPrice = txtPrice.Value;
            string reviewLocation = txtLocation.Value;
            string reviewHome = txtHome.Value;


            txtReviewerName.Value = string.Empty;
            ddlRating.SelectedIndex = 0;
            txtPrice.Value = string.Empty;
            txtLocation.Value = string.Empty;
            txtHome.Value = string.Empty;

            OnReviewSubmitted(new Reviews(reviewerName, rating, reviewPrice, reviewLocation, reviewHome));
        }
    }
}