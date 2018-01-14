using System;
using IslahGroup.DotNet.BusinessLogicLayer;
using IslahGroup.DotNet.EntityLayer;

namespace IslahGroup.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string username = TextboxUsername.Text;
            string password = TextPassword.Text;

            MemberLogic ml = new MemberLogic();
            IGUser currentUser = ml.LoginToTheSystem(username, password);
            if (currentUser != null)
            {
                ResultLabel.Text = "Login Successful!";

                Session["UserId"] = currentUser.UserId;
                Session["AName"] = currentUser.AName;
                Session["AUsername"] = currentUser.AUsername;
                Session["UserType"] = currentUser.UserType;
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                ResultLabel.Text = "Login Unsuccessful!";
            }

        }
    }
}