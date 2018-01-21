using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class RegisterMember : System.Web.UI.Page
    {
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
            string introducerName = IntroducerName.Text;
            string introducerShareNo = IntroducerShareNo.Text;
            // Photo url
            string memberImageUpload="";
            string nomineeImageUpload="";

            UploadImage();

        }

        private void UploadImage()
        {
            if (MemberImageUpload.HasFile)
            {
                string fileName = Path.GetFileName(MemberImageUpload.PostedFile.FileName);
                MemberImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/MemberPhoto/") + fileName);
                Response.Redirect(Request.Url.AbsoluteUri);
            }

            if(NomineeImageUpload.HasFile)
            {
                string fileName = Path.GetFileName(NomineeImageUpload.PostedFile.FileName);
                NomineeImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/NomineePhoto/") + fileName);
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
    }
}