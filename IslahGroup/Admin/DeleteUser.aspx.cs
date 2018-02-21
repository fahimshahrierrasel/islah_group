using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;

namespace IslahGroup.Admin
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        string userId;
        IGUserLogic iGUserLogic;
        public DeleteUser()
        {
            iGUserLogic = new IGUserLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Request.QueryString["UID"].ToString();
            Dictionary<string, string> user = new Dictionary<string, string>()
            {
                { "UserId", userId }
            };
            iGUserLogic.DeleteIGUser(user);
            Response.Redirect("Management.aspx");
        }
    }
}