using System;
using System.Web.UI.WebControls;
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

            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                ShowWarningWith("Username/Password cann't be empty");
            }
            else { 
                MemberLogic ml = new MemberLogic();
                IGUser currentUser = ml.LoginToTheSystem(username, password);
                if (currentUser != null)
                {
                    Session["UserId"] = currentUser.UserId;
                    Session["AName"] = currentUser.AName;
                    Session["AUsername"] = currentUser.AUsername;
                    Session["UserType"] = currentUser.UserType;
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    ShowWarningWith("Your credential is not correct!!");
                }
            }
        }

        private void ShowWarningWith(String message)
        {
            PanelLoginMessage.CssClass = PanelLoginMessage.CssClass.Replace("d-none", "");
            Label label = new Label
            {
                Text = message
            };
            PanelLoginMessage.Controls.Add(label);
        }
    }
}