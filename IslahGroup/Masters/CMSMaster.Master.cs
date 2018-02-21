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
            else
            {
                LabelUserName.Text = Session["AName"].ToString() + "(" + Session["UserType"] + ")";

                if (Session["UserType"].ToString() != "Admin" || Session["UserType"].ToString() != "Director" || Session["UserType"].ToString() != "CMSAdmin")
                {
                    Response.Write("<script>alert('You have no authorization in this area!!')</script>");
                    Response.Redirect("../Default.aspx");
                }
            }

        }
    }
}