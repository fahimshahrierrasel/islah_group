using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Masters
{
    public partial class CMSMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AUsername"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            LabelUserName.Text = Session["AName"].ToString() + "(" + Session["UserType"] + ")";
        }
    }
}