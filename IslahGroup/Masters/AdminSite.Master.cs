using System;

namespace IslahGroup.Masters
{
    public partial class AdminSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AUsername"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            LabelUserName.Text = Session["AName"].ToString()+"("+Session["UserType"]+")";

            if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
            {
                Owners.Visible = true;
            }
            else
            {
                Owners.Visible = false;
            }
            

        }
    }
}