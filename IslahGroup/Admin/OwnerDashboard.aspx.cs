using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;

namespace IslahGroup.Admin
{
    public partial class OwnerDashboard : System.Web.UI.Page
    {
        private OwnerLogic ownerLogic;
        private MemberDepositLogic memberDepositLogic;
        public DataTable memberInfo;
        public DataTable depositInfo;
        private string email;
        public OwnerDashboard()
        {
            ownerLogic = new OwnerLogic();
            memberDepositLogic = new MemberDepositLogic();
            memberInfo = new DataTable();
            depositInfo = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            email = Session["Email"].ToString();
            LoadOwner(email);
            PopulateMemberInformation();
        }
        private void LoadOwner(string email)
        {
            memberInfo.Clear();
            Dictionary<string, string> memberInformation = new Dictionary<string, string>
            {
                { "Email", email }
            };

            memberInfo = ownerLogic.GetSingleOwnerByEmail(memberInformation);

            PopulateMemberDeposits(new Dictionary<string, int>()
            {
                { "MemberId",  Convert.ToInt32(memberInfo.Rows[0]["MemberId"])
                }
            });
        }

        private void PopulateMemberDeposits(Dictionary<string, int> memberInformation)
        {
            depositInfo.Clear();
            depositInfo = memberDepositLogic.GetMemberDeposits(memberInformation);
            RepeaterOwnerDeposits.DataSource = depositInfo;
            RepeaterOwnerDeposits.DataBind();
        }

        private void PopulateMemberInformation()
        {
            if (memberInfo.Rows.Count == 1)
            {
                DataRow dr = memberInfo.Rows[0];
                Page.Title = dr["FullName"].ToString();
                LabelMemberName.Text = dr["FullName"].ToString();
                LabelMemberShipId.Text = dr["MembershipId"].ToString();
                LabelFullName.Text = dr["FullName"].ToString();
                LabelNID.Text = dr["NID"].ToString();
                LabelFatherName.Text = dr["FatherName"].ToString();
                LabelMotherName.Text = dr["MotherName"].ToString();
                LabelHusbWifeName.Text = dr["HusbWifeName"].ToString();
                LabelPresentAddress.Text = dr["PresentAddress"].ToString();
                LabelParmanentAddress.Text = dr["ParmanentAddress"].ToString();
                LabelDOB.Text = DateTime.Parse(dr["DateOfBirth"].ToString()).Date.ToString();
                LabelEducation.Text = dr["Education"].ToString();
                LabelNationality.Text = dr["Nationality"].ToString();
                LabelGender.Text = dr["Gender"].ToString();
                LabelBloodGroup.Text = dr["BloodGroup"].ToString();
                LabelMobileNo.Text = dr["MobileNo"].ToString();
                LabelRegistrationDate.Text = DateTime.Parse(dr["RegistrationDate"].ToString()).Date.ToString();
                LabelAmount.Text = dr["Amount"].ToString();
                LabelProfit.Text = dr["Profit"].ToString();
                LabelNomineeNID.Text = dr["NomineeNidNo"].ToString();
                LabelNomineeName.Text = dr["NomineeName"].ToString();
                LabelNomineeFatherHusbandName.Text = dr["NomineeFatherHusbandName"].ToString();
                LabelNomineeMotherName.Text = dr["NomineeMotherName"].ToString();
                LabelNomineeAddress.Text = dr["NomineeAddress"].ToString();
                LabelNomineeDOB.Text = DateTime.Parse(dr["NomineeDateOfBirth"].ToString()).Date.ToString();
                LabelNomineeRelation.Text = dr["NomineeRelation"].ToString();
                LabelNomineeProfession.Text = dr["NomineeProfession"].ToString();
                LabelNomineeMobileNo.Text = dr["NomineeMobileNo"].ToString();
                HyperLinkEmail.Text = dr["Email"].ToString();
                HyperLinkEmail.NavigateUrl = "mailto:" + dr["Email"].ToString();
                ImageMember.ImageUrl = dr["ImageUrl"].ToString();
                ImageNominee.ImageUrl = dr["NomineeImageUrl"].ToString();

                if(Convert.ToDouble(dr["Amount"].ToString()) < 150000d)
                {
                    ProfitCard.Visible = false;
                    WarningCard.Visible = true;
                }
                else
                {
                    ProfitCard.Visible = true;
                    WarningCard.Visible = false;
                }
            }
        }
    }
}