using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class MemberDetails : System.Web.UI.Page
    {
        public DataTable memberInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            memberInfo = new DataTable();
            int memberId = Convert.ToInt32(Request.QueryString["MemId"]);
            LoadOwner(memberId);
            PopulateFields();
        }
        private void LoadOwner(int memberId)
        {
            memberInfo.Clear();
            Dictionary<string, int> memberInformation = new Dictionary<string, int>
            {
                { "Memeber_Id", memberId }
            };
            OwnerLogic ol = new OwnerLogic();
            memberInfo = ol.GetOwner(memberInformation);
        }

        private void PopulateFields()
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
            LabelDOB.Text = dr["DateOfBirth"].ToString();
            LabelEducation.Text = dr["Education"].ToString();
            LabelNationality.Text = dr["Nationality"].ToString();
            LabelGender.Text = dr["Gender"].ToString();
            LabelBloodGroup.Text = dr["BloodGroup"].ToString();
            LabelMobileNo.Text = dr["MobileNo"].ToString();
            
            LabelRegistrationDate.Text = dr["RegistrationDate"].ToString();
            LabelAmount.Text = dr["Amount"].ToString();
            LabelNomineeNID.Text = dr["NomineeNidNo"].ToString();
            LabelNomineeName.Text = dr["NomineeName"].ToString();
            LabelNomineeFatherHusbandName.Text = dr["NomineeFatherHusbandName"].ToString();
            LabelNomineeMotherName.Text = dr["NomineeMotherName"].ToString();
            LabelNomineeAddress.Text = dr["NomineeAddress"].ToString();
            LabelNomineeDOB.Text = dr["NomineeDateOfBirth"].ToString();
            LabelNomineeRelation.Text = dr["NomineeRelation"].ToString();
            LabelNomineeProfession.Text = dr["NomineeProfession"].ToString();
            LabelNomineeMobileNo.Text = dr["NomineeMobileNo"].ToString();
        }

        protected void ButtonAddODeposit_Click(object sender, EventArgs e)
        {

        }
    }
}