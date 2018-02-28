using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web.UI;

namespace IslahGroup.Admin
{
    public partial class UpdateOwner : System.Web.UI.Page
    {
        string memberId;
        OwnerLogic ownerLogic;
        DataTable memberInfo;
        enum PhotoType { Member, Nominee };

        public UpdateOwner()
        {
            ownerLogic = new OwnerLogic();
            memberInfo = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            memberId = Request.QueryString["MemId"].ToString();
            if (!IsPostBack)
            {
                LoadOwner(Convert.ToInt32(memberId));
                PopulateMemberInformation();
            }
        }
        private void LoadOwner(int memberId)
        {
            memberInfo.Clear();
            Dictionary<string, int> memberInformation = new Dictionary<string, int>
            {
                { "MemberId", memberId }
            };

            memberInfo = ownerLogic.GetSingleOwner(memberInformation);
        }
        private void PopulateMemberInformation()
        {
            if (memberInfo.Rows.Count == 1)
            {
                DataRow dr = memberInfo.Rows[0];
                Page.Title = dr["FullName"].ToString();
                RegistrationDate.Text = DateTime.Parse(dr["RegistrationDate"].ToString()).Date.ToString("dd-MM-yyyy");
                ShareNo.Text = dr["ShareNo"].ToString();
                FullName.Text = dr["FullName"].ToString();
                NidNo.Text = dr["NID"].ToString();
                FatherName.Text = dr["FatherName"].ToString();
                MotherName.Text = dr["MotherName"].ToString();
                HusbWifeName.Text = dr["HusbWifeName"].ToString();
                PresentAddress.Text = dr["PresentAddress"].ToString();
                ParmanentAddress.Text = dr["ParmanentAddress"].ToString();
                DateOfBirth.Text = DateTime.Parse(dr["DateOfBirth"].ToString()).Date.ToString("dd-MM-yyyy");
                Education.Text = dr["Education"].ToString();
                Nationality.Text = dr["Nationality"].ToString();
                Gender.Text = dr["Gender"].ToString();
                Profession.Text = dr["Profession"].ToString();
                BloodGroup.Text = dr["BloodGroup"].ToString();
                MobileNo.Text = dr["MobileNo"].ToString();
                NomineeNidNo.Text = dr["NomineeNidNo"].ToString();
                NomineeName.Text = dr["NomineeName"].ToString();
                NomineeFatherHusbandName.Text = dr["NomineeFatherHusbandName"].ToString();
                NomineeMotherName.Text = dr["NomineeMotherName"].ToString();
                NomineeAddress.Text = dr["NomineeAddress"].ToString();
                NomineeDateOfBirth.Text = DateTime.Parse(dr["NomineeDateOfBirth"].ToString()).Date.ToString("dd-MM-yyyy");
                NomineeRelation.Text = dr["NomineeRelation"].ToString();
                NomineeProfession.Text = dr["NomineeProfession"].ToString();
                NomineeMobileNo.Text = dr["NomineeMobileNo"].ToString();
                Email.Text = dr["Email"].ToString();
                ImageMember.ImageUrl = dr["ImageUrl"].ToString();
                ImageNominee.ImageUrl = dr["NomineeImageUrl"].ToString();
                HiddenImageLabel.Text = dr["ImageUrl"].ToString();
                HiddenNomineeImageLabel.Text = dr["NomineeImageUrl"].ToString();
            }
        }
        protected void UpdateFormSubmit_Click(object sender, EventArgs e)
        {
            // Member Personal Info
            string registrationDate = RegistrationDate.Text;
            string shareNo = ShareNo.Text;
            string nidNo = NidNo.Text;
            string fullName = FullName.Text;
            string fatherName = FatherName.Text;
            string motherName = MotherName.Text;
            string husbWifeName = HusbWifeName.Text;
            string presentAddress = PresentAddress.Text;
            string parmanentAddress = ParmanentAddress.Text;
            string dob = DateOfBirth.Text;
            string education = Education.Text;
            string profession = Profession.Text;
            string nationality = Nationality.Text;
            string gender = Gender.Text;
            string bloodGroup = BloodGroup.Text;
            string mobileNo = MobileNo.Text;
            string email = Email.Text;
            string designation = TextBoxDesignation.Text;

            // Nominee's Info
            string nomineeNidNo = NomineeNidNo.Text;
            string nomineeName = NomineeName.Text;
            string nomineeFatherHusbandName = NomineeFatherHusbandName.Text;
            string nomineeMotherName = NomineeMotherName.Text;
            string nomineeAddress = NomineeAddress.Text;
            string nomineeDob = NomineeDateOfBirth.Text;
            string nomineeRelation = NomineeRelation.Text;
            string nomineeProfession = NomineeProfession.Text;
            string nomineeMobileNo = NomineeMobileNo.Text;

            string memberImageUploadPath = "";
            string nomineeImageUploadPath = "";

            if (MemberImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(MemberImageUpload.PostedFile.FileName);
                memberImageUploadPath = @"~/Upload/Images/Owners/" + ImageName(fullName, mobileNo, PhotoType.Member) + fileExtension;
                RemoveFileIfExists(memberImageUploadPath);
                MemberImageUpload.SaveAs(Server.MapPath(memberImageUploadPath));
            }
            else
            {
                memberImageUploadPath = HiddenImageLabel.Text;
            }

            if (NomineeImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(NomineeImageUpload.PostedFile.FileName);
                nomineeImageUploadPath = @"~/Upload/Images/Nominees/" + ImageName(fullName, mobileNo, PhotoType.Nominee) + fileExtension;
                RemoveFileIfExists(nomineeImageUploadPath);
                NomineeImageUpload.SaveAs(Server.MapPath(nomineeImageUploadPath));
            }
            else
            {
                nomineeImageUploadPath = HiddenNomineeImageLabel.Text;
            }

            Dictionary<string, string> memberInformation = new Dictionary<string, string>
            {
                { "ShareNo", shareNo },
                { "NID", nidNo },
                { "FullName", fullName },
                { "FatherName", fatherName },
                { "MotherName", motherName },
                { "HusbWifeName", husbWifeName },
                { "PresentAddress", presentAddress },
                { "ParmanentAddress", parmanentAddress },
                { "DateOfBirth", dob },
                { "Education", education },
                { "Profession", profession },
                { "Nationality", nationality },
                { "Gender", gender },
                { "BloodGroup", bloodGroup },
                { "MobileNo", mobileNo },
                { "Email", email },
                { "Designation", designation },
                { "ImageUrl", memberImageUploadPath },
                { "RegistrationDate", registrationDate },
                { "NomineeNidNo", nomineeNidNo },
                { "NomineeName", nomineeName },
                { "NomineeFatherHusbandName", nomineeFatherHusbandName },
                { "NomineeMotherName", nomineeMotherName },
                { "NomineeAddress", nomineeAddress },
                { "NomineeDateOfBirth", nomineeDob },
                { "NomineeRelation", nomineeRelation },
                { "NomineeProfession", nomineeProfession },
                { "NomineeMobileNo", nomineeMobileNo },
                { "NomineeImageUrl", nomineeImageUploadPath },
                { "MemberId", memberId }
            };
            ownerLogic.UpdateOwner(memberInformation);
            Response.Redirect("OwnerDetails.aspx?MemId=" + memberId);
        }
        private string ImageName(string name, string mobileNo, PhotoType photoType)
        {
            string newName = NameWithoutSymbol(name) + mobileNo.Substring(mobileNo.Length - 6);
            if (photoType == PhotoType.Nominee)
            {
                newName = newName + "_nominee";
            }
            return newName;
        }
        private string NameWithoutSymbol(string name)
        {
            return name.Replace(" ", String.Empty)
                    .Replace(".", String.Empty)
                    .Replace("-", String.Empty)
                    .Replace(",", String.Empty)
                    .ToLower();
        }
        private void RemoveFileIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}