using System;
using System.Collections.Generic;
using System.IO;
using IslahGroup.DotNet.BusinessLogicLayer;

namespace IslahGroup.Admin
{
    public partial class RegisterOwner : System.Web.UI.Page
    {
        enum PhotoType { Member, Nominee};
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void FormSubmit_Click(object sender, EventArgs e)
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
                memberImageUploadPath = Server.MapPath(@"~/Upload/Images/Owners/" + ImageName(fullName,PhotoType.Member) + fileExtension);
                RemoveFileIfExists(memberImageUploadPath);
                MemberImageUpload.SaveAs(memberImageUploadPath);
            }

            if (NomineeImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(NomineeImageUpload.PostedFile.FileName);
                nomineeImageUploadPath = Server.MapPath(@"~/Upload/Images/Nominees/" + ImageName(fullName, PhotoType.Nominee) + fileExtension);
                RemoveFileIfExists(nomineeImageUploadPath);
                NomineeImageUpload.SaveAs(nomineeImageUploadPath);
            }

            OwnerLogic memberLogic = new OwnerLogic();

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
                { "NomineeImageUrl", nomineeImageUploadPath }
            };

            Response.Write("<script>console.log('Member Not Add');</script>");

            try
            {
                if (memberLogic.RegisterNewOwner(memberInformation))
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

        private string ImageName(string name, PhotoType photoType)
        {
            string newName = name.Replace(" ", String.Empty)
                    .Replace(".", String.Empty)
                    .Replace("-", String.Empty)
                    .Replace(",", String.Empty)
                    .ToLower();
            if(photoType == PhotoType.Nominee)
            {
                newName = newName + "_nominee";
            }
            return newName;
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