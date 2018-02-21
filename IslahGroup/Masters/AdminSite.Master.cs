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
            else
            {
                LabelUserName.Text = Session["AName"].ToString() + "(" + Session["UserType"] + ")";

                if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
                {
                    OwnersMenu.Visible = true;
                    MemberMenu.Visible = true;
                }
                else if (Session["UserType"].ToString() == "Member")
                {
                    OwnersMenu.Visible = false;
                    MemberMenu.Visible = false;
                    DashboardLink.HRef = "../Admin/OwnerDashboard.aspx";
                }
                else
                {
                    Response.Write("<script>alert('You have no authorization in this area!!')</script>");
                    Response.Redirect("../Default.aspx");
                }
            }
        }
    }
}