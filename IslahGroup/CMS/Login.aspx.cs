using IslahGroup.DotNet.BusinessLogicLayer;
using IslahGroup.DotNet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace IslahGroup.CMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string email = TextboxEmail.Text;
            string password = TextPassword.Text;

            Dictionary<string, string> userInformation = new Dictionary<string, string>()
            {
                { "Email", email },
                { "Password", password }
            };

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                ShowWarningWith("Email/Password cann't be empty");
            }
            else
            {
                IGUserLogic ml = new IGUserLogic();
                IGUser currentUser = null;
                try
                {
                    currentUser = ml.LoginToTheSystem(userInformation);
                }
                catch (Exception ex)
                {
                    ShowWarningWith(ex.Message);
                }

                if (currentUser != null)
                {
                    Session["UserId"] = currentUser.UserId;
                    Session["AName"] = currentUser.AName;
                    Session["AUsername"] = currentUser.AUsername;
                    Session["Email"] = currentUser.Email;
                    Session["UserType"] = currentUser.UserType;

                    Response.Redirect("Default.aspx");
                    
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