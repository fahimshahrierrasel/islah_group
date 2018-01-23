using System;

namespace IslahGroup.DotNet.EntityLayer
{
    public class Member
    {
        public int MemberId { get; set; }
        public string ShareNo { get; set; }
        public string NID { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HusbWifeName { get; set; }
        public string PresentAddress { get; set; }
        public string ParmanentAddress { get; set; }
        public DateTime DOB { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
