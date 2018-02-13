using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class InvestorDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAuthorization();
        }

        public void ControlAuthorization()
        {
            if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
            {
                add_modal.Visible = true;
            }
            else
            {
                add_modal.Visible = false;
            }
        }
    }
}