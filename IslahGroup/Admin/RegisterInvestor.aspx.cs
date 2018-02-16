using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;

namespace IslahGroup.Admin
{
    public partial class RegisterInvestor : System.Web.UI.Page
    {
        InvestorLogic investorLogic;

        public RegisterInvestor()
        {
            investorLogic = new InvestorLogic();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddInvestor_Click(object sender, EventArgs e)
        {
            string nid = TextBoxInvNID.Text;
            string fullName = TextBoxInvFullName.Text;
            string fatherName = TextBoxInvFatherName.Text;
            string motherName = TextBoxInvMotherName.Text;
            string husbWifeName = TextBoxInvHusbWifeName.Text;
            string presentAddress = TextBoxParmanentAddress.Text;
            string parmanentAddress = TextBoxParmanentAddress.Text;
            string dob = TextBoxInvDOB.Text;
            string profession = TextBoxProfession.Text;
            string gender = DropDownListInvGender.Text;
            string mobileNo = TextBoxInvMobileNo.Text;
            string userId = Session["UserId"].ToString();
            Dictionary<string, string> investorInfo = new Dictionary<string, string>()
            {
                { "InvNID", nid },
                { "InvFullName", fullName },
                { "InvFatherName", fatherName },
                { "InvMotherName", motherName },
                { "InvHusbWifeName", husbWifeName },
                { "InvPresentAddress", presentAddress },
                { "InvParmanentAddress", parmanentAddress },
                { "InvDOB", dob },
                { "InvProfession", profession },
                { "InvGender", gender },
                { "InvMobileNo", mobileNo },
                { "UserId", userId }
            };

            if (investorLogic.RegisterNewInvestor(investorInfo))
                Response.Redirect("Investors.aspx");
        }
    }
}