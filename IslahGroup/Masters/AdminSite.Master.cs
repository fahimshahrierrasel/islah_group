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

            LabelUserName.Text = Session["AName"].ToString() + "(" + Session["UserType"] + ")";

            if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
            {
                OwnersMenu.Visible = true;
                MemberMenu.Visible = true;
                ManagementMenu.Visible = true;
            }
            else if (Session["UserType"].ToString() == "Owner")
            {
                OwnersMenu.Visible = true;
                MemberMenu.Visible = true;
                MemberRequestsLink.Visible = false;
                MemberHaltLink.Visible = false;
                ManagementMenu.Visible = false;
                DashboardLink.HRef = "../Admin/OwnerDashboard.aspx";
            }
            else
            {
                Response.Write("<script>alert('You have no authorization in this area!!');" +
                                        "window.history.go(-1);</script>");
            }
        }
    }
}