﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class Expenditure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddODeposit_Click(object sender, EventArgs e)
        {
            string eDate = TextBoxEDate.Text;
            string eNote = TextBoxEInfo.Text;
            string eType = DropDownListEType.Text;
            string amount = TextBoxEAmount.Text;
        }
    }
}