using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelFullName.Text = Session["AName"].ToString();
            LabelEmail.Text = Session["Email"].ToString();
            LabelUsername.Text = Session["AUsername"].ToString();
            LabelUserType.Text = Session["UserType"].ToString();
        }
    }
}