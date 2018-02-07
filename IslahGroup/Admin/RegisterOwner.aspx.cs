using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using IslahGroup.DotNet.BusinessLogicLayer;

namespace IslahGroup.Admin
{
    public partial class RegisterOwner : System.Web.UI.Page
    {
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
            // Introducer's Info
            //string introducerName = IntroducerName.Text;
            //string introducerShareNo = IntroducerShareNo.Text;
            // Photo url
            string memberImageUploadPath = "";
            string nomineeImageUploadPath = "";
            string memberImageFolder = Server.MapPath(@"~/Upload/Images/Owners/");
            string nomineeImageFolder = Server.MapPath(@"~/Upload/Images/Nominees/");

            if (MemberImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(MemberImageUpload.PostedFile.FileName);
                memberImageUploadPath = memberImageFolder + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + fileExtension;
                MemberImageUpload.SaveAs(memberImageUploadPath);
            }

            if (NomineeImageUpload.HasFile)
            {
                string fileExtension = Path.GetExtension(NomineeImageUpload.PostedFile.FileName);
                nomineeImageUploadPath = nomineeImageFolder + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + fileExtension;
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

    }
}