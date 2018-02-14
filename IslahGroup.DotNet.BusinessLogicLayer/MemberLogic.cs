using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using IslahGroup.DotNet.DataAccessLayer;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class MemberLogic
    {
        MemberData memberData;
        public MemberLogic()
        {
            memberData = new MemberData();
        }
        public bool RegisterNewMember(Dictionary<string, string> memberInformation)
        {
            SqlParameter[] parameters = new SqlParameter[memberInformation.Count];
            parameters[0] = new SqlParameter("ShareNo", memberInformation["ShareNo"]);
            parameters[1] = new SqlParameter("NID", memberInformation["NID"]);
            parameters[2] = new SqlParameter("FullName", memberInformation["FullName"]);
            parameters[3] = new SqlParameter("FatherName", memberInformation["FatherName"]);
            parameters[4] = new SqlParameter("MotherName", memberInformation["MotherName"]);
            parameters[5] = new SqlParameter("HusbWifeName", memberInformation["HusbWifeName"]);
            parameters[6] = new SqlParameter("PresentAddress", memberInformation["PresentAddress"]);
            parameters[7] = new SqlParameter("ParmanentAddress", memberInformation["ParmanentAddress"]);
            parameters[8] = new SqlParameter("DateOfBirth", DateTime.Parse(memberInformation["DateOfBirth"]));
            parameters[9] = new SqlParameter("Education", memberInformation["Education"]);
            parameters[10] = new SqlParameter("Profession", memberInformation["Profession"]);
            parameters[11] = new SqlParameter("Nationality", memberInformation["Nationality"]);
            parameters[12] = new SqlParameter("Gender", memberInformation["Gender"]);
            parameters[13] = new SqlParameter("BloodGroup", memberInformation["BloodGroup"]);
            parameters[14] = new SqlParameter("MobileNo", memberInformation["MobileNo"]);
            parameters[15] = new SqlParameter("Email", memberInformation["Email"]);
            parameters[16] = new SqlParameter("ImageUrl", memberInformation["ImageUrl"]);
            parameters[17] = new SqlParameter("RegistrationDate", DateTime.Parse(memberInformation["RegistrationDate"]));
            parameters[18] = new SqlParameter("NomineeNidNo", memberInformation["NomineeNidNo"]);
            parameters[19] = new SqlParameter("NomineeName", memberInformation["NomineeName"]);
            parameters[20] = new SqlParameter("NomineeFatherHusbandName", memberInformation["NomineeFatherHusbandName"]);
            parameters[21] = new SqlParameter("NomineeMotherName", memberInformation["NomineeMotherName"]);
            parameters[22] = new SqlParameter("NomineeAddress", memberInformation["NomineeAddress"]);
            parameters[23] = new SqlParameter("NomineeDateOfBirth", DateTime.Parse(memberInformation["NomineeDateOfBirth"]));
            parameters[24] = new SqlParameter("NomineeRelation", memberInformation["NomineeRelation"]);
            parameters[25] = new SqlParameter("NomineeProfession", memberInformation["NomineeProfession"]);
            parameters[26] = new SqlParameter("NomineeMobileNo", memberInformation["NomineeMobileNo"]);
            parameters[27] = new SqlParameter("NomineeImageUrl", memberInformation["NomineeImageUrl"]);
            parameters[28] = new SqlParameter("Designation", memberInformation["Designation"]);
            parameters[29] = new SqlParameter("IntroMembershipId", memberInformation["IntroducerMembershipId"]);

            if (memberData.Insert(parameters))
            {
                return true;
            }
            return false;
        }

        public DataTable GetAllMemberByActiveStatus(Dictionary<string, int> filterInformation)
        {
            SqlParameter[] parameters = new SqlParameter[filterInformation.Count];
            parameters[0] = new SqlParameter("Status", filterInformation["Status"]);
            DataTable membersTable = new DataTable();
            membersTable = memberData.GetAllMembersByStatus(parameters);
            return membersTable;
        }

        public DataTable GetSingleMember(Dictionary<string, int> memberInformation)
        {
            SqlParameter[] parameters = new SqlParameter[memberInformation.Count];
            parameters[0] = new SqlParameter("MemberId", memberInformation["MemberId"]);
            DataTable singleOwnerTable = new DataTable();
            singleOwnerTable = memberData.GetSingleMember(parameters);
            return singleOwnerTable;
        }
    }
}
