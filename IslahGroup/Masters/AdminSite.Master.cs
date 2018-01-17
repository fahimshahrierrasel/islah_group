using System;

namespace IslahGroup.Masters
{
    public partial class AdminSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(Session["AUsername"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
                LabelUserName.Text = Session["AName"].ToString();
        }
    }
}