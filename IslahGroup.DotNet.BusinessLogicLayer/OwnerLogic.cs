using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IslahGroup.DotNet.DataAccessLayer;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class OwnerLogic
    {
        private OwnerData ownerData;

        public OwnerLogic()
        {
            ownerData = new OwnerData();
        }
        public bool RegisterNewOwner(Dictionary<string, string> memberInformation)
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
            parameters[8] = new SqlParameter("DateOfBirth", DateTime.Parse(memberInformation["DateOfBirth"]).Date);
            parameters[9] = new SqlParameter("Education", memberInformation["Education"]);
            parameters[10] = new SqlParameter("Profession", memberInformation["Profession"]);
            parameters[11] = new SqlParameter("Nationality", memberInformation["Nationality"]);
            parameters[12] = new SqlParameter("Gender", memberInformation["Gender"]);
            parameters[13] = new SqlParameter("BloodGroup", memberInformation["BloodGroup"]);
            parameters[14] = new SqlParameter("MobileNo", memberInformation["MobileNo"]);
            parameters[15] = new SqlParameter("Email", memberInformation["Email"]);
            parameters[16] = new SqlParameter("ImageUrl", memberInformation["ImageUrl"]);
            parameters[17] = new SqlParameter("RegistrationDate", DateTime.Parse(memberInformation["RegistrationDate"]).Date);
            parameters[18] = new SqlParameter("NomineeNidNo", memberInformation["NomineeNidNo"]);
            parameters[19] = new SqlParameter("NomineeName", memberInformation["NomineeName"]);
            parameters[20] = new SqlParameter("NomineeFatherHusbandName", memberInformation["NomineeFatherHusbandName"]);
            parameters[21] = new SqlParameter("NomineeMotherName", memberInformation["NomineeMotherName"]);
            parameters[22] = new SqlParameter("NomineeAddress", memberInformation["NomineeAddress"]);
            parameters[23] = new SqlParameter("NomineeDateOfBirth", DateTime.Parse(memberInformation["NomineeDateOfBirth"]).Date);
            parameters[24] = new SqlParameter("NomineeRelation", memberInformation["NomineeRelation"]);
            parameters[25] = new SqlParameter("NomineeProfession", memberInformation["NomineeProfession"]);
            parameters[26] = new SqlParameter("NomineeMobileNo", memberInformation["NomineeMobileNo"]);
            parameters[27] = new SqlParameter("NomineeImageUrl", memberInformation["NomineeImageUrl"]);

            if (ownerData.Insert(parameters))
            {
                return true;
            }
            return false;
        }

        public DataTable GetSingleOwner(Dictionary<string, int> memberInformation)
        {
            SqlParameter[] parameters = new SqlParameter[memberInformation.Count];
            parameters[0] = new SqlParameter("MemberId", memberInformation["MemberId"]);
            DataTable singleOwnerTable = new DataTable();
            singleOwnerTable = ownerData.GetSingleMember(parameters);
            return singleOwnerTable;
        }

        public DataTable GetAllOwners()
        {
            DataTable allOwnerTable = new DataTable();
            allOwnerTable = ownerData.GetAllMembers();
            return allOwnerTable;
        }

        public bool AddDeposit(Dictionary<string, string> depositInformation)
        {
            SqlParameter[] parameters = new SqlParameter[depositInformation.Count];
            parameters[0] = new SqlParameter("DepositDate", DateTime.Parse(depositInformation["DepositDate"]).Date);
            parameters[1] = new SqlParameter("Amount", depositInformation["Amount"]);
            parameters[2] = new SqlParameter("Note", depositInformation["Note"]);
            parameters[3] = new SqlParameter("MemberId", depositInformation["MemberId"]);
            parameters[4] = new SqlParameter("UserId", depositInformation["UserId"]);
            ownerData.InsertNewDeposit(parameters);
            return true;
        }

        public DataTable GetOwnerDeposits(Dictionary<string, int> memberInformation)
        {
            SqlParameter[] parameters = new SqlParameter[memberInformation.Count];
            parameters[0] = new SqlParameter("MemberId", memberInformation["MemberId"]);
            DataTable singleOwnerTable = new DataTable();
            singleOwnerTable = ownerData.GetMemberDeposits(parameters);
            return singleOwnerTable;
        }
    }
}
