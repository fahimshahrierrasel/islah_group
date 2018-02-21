using System;

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

            if (Session["UserType"].ToString().Equals("Admin") || Session["UserType"].ToString().Equals("Director") || Session["UserType"].ToString().Equals("CMSAdmin"))
            {
                
            }
            else
            {
                Response.Write("<script>alert('You have no authorization in this area!!')</script>");
                Response.Redirect("../Default.aspx");
            }

        }
    }
}