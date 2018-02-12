﻿using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;

namespace IslahGroup.Admin
{
    public partial class MemberDetails : System.Web.UI.Page
    {
        private OwnerLogic ol;
        public DataTable memberInfo;
        public DataTable depositInfo;
        private int memberId;
        public MemberDetails()
        {
            ol = new OwnerLogic();
            memberInfo = new DataTable();
            depositInfo = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            memberId = Convert.ToInt32(Request.QueryString["MemId"]);
            LoadOwner(memberId);
            PopulateMemberInformation();
        }
        private void LoadOwner(int memberId)
        {
            memberInfo.Clear();
            Dictionary<string, int> memberInformation = new Dictionary<string, int>
            {
                { "MemberId", memberId }
            };
            
            memberInfo = ol.GetSingleOwner(memberInformation);
            PopulateMemberDeposits(memberInformation);
        }

        private void PopulateMemberDeposits(Dictionary<string, int> memberInformation)
        {
            depositInfo.Clear();
            depositInfo = ol.GetOwnerDeposits(memberInformation);
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
            }
        }

        protected void ButtonAddODeposit_Click(object sender, EventArgs e)
        {
            string depositAmount = TextBoxDAmount.Text;
            string depositDate = TextBoxDDate.Text;
            string depositNote = TextBoxDNote.Text;
            string userId = Session["UserId"].ToString();

            Dictionary<string, string> memberDepositInfo = new Dictionary<string, string>
            {
                { "DepositDate", depositDate},
                { "Amount", depositAmount },
                { "Note", depositNote },
                { "UserId", userId },
                { "MemberId", memberId.ToString() }
            };
            ol.AddDeposit(memberDepositInfo);
            Response.Redirect(Page.Request.RawUrl);
        }
    }
}