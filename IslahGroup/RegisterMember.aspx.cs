using System;
using System.Collections.Generic;
using System.IO;
using IslahGroup.DotNet.BusinessLogicLayer;

namespace IslahGroup
{
    public partial class RegisterMember : System.Web.UI.Page
    {
        enum PhotoType { Member, Nominee };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FormSubmit_Click(object sender, EventArgs e)
        {
            // Member Personal Info
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

            // Introducer's Info
            string introducerMembershipId = IntroducerMembershipId.Text;

            // Photo url
            string memberImageUploadPath = "";
            string nomineeImageUploadPath = "";

            if (MemberImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(MemberImageUpload.PostedFile.FileName);
                memberImageUploadPath = @"~/Upload/Images/Members/" + ImageName(fullName, mobileNo, PhotoType.Member) + fileExtension;
                MemberImageUpload.SaveAs(Server.MapPath(memberImageUploadPath));
            }

            if (NomineeImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(NomineeImageUpload.PostedFile.FileName);
                nomineeImageUploadPath = @"~/Upload/Images/Nominees/" + ImageName(fullName, mobileNo, PhotoType.Nominee) + fileExtension;
                NomineeImageUpload.SaveAs(Server.MapPath(nomineeImageUploadPath));
            }

            MemberLogic memberLogic = new MemberLogic();

            Dictionary<string, string> memberInformation = new Dictionary<string, string>
            {
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
                { "Designation", "Member" },
                { "ImageUrl", memberImageUploadPath },
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
                { "IntroducerMembershipId", introducerMembershipId }
            };

            try
            {
                if (memberLogic.RegisterNewMember(memberInformation))
                {
                    Response.Redirect("~/Admin/Owners.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    Response.Write("<script>alert('Member Not Add');</script>");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
    }
}