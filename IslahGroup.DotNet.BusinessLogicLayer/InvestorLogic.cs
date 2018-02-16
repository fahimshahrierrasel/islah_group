using IslahGroup.DotNet.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class InvestorLogic
    {
        InvestorData investorData;

        public InvestorLogic()
        {
            investorData = new InvestorData();
        }

        public bool RegisterNewInvestor(Dictionary<string, string> investorInfo)
        {
            SqlParameter[] parameters = new SqlParameter[investorInfo.Count];
            parameters[0] = new SqlParameter("InvNID", investorInfo["InvNID"]);
            parameters[1] = new SqlParameter("InvFullName", investorInfo["InvFullName"]);
            parameters[2] = new SqlParameter("InvFatherName", investorInfo["InvFatherName"]);
            parameters[3] = new SqlParameter("InvMotherName", investorInfo["InvMotherName"]);
            parameters[4] = new SqlParameter("InvHusbWifeName", investorInfo["InvHusbWifeName"]);
            parameters[5] = new SqlParameter("InvPresentAddress", investorInfo["InvPresentAddress"]);
            parameters[6] = new SqlParameter("InvParmanentAddress", investorInfo["InvParmanentAddress"]);
            parameters[7] = new SqlParameter("InvDateOfBirth", DateTime.Parse(investorInfo["InvDOB"]).Date);
            parameters[8] = new SqlParameter("InvProfession", investorInfo["InvProfession"]);
            parameters[9] = new SqlParameter("InvGender", investorInfo["InvGender"]);
            parameters[10] = new SqlParameter("InvMobileNo", investorInfo["InvMobileNo"]);
            parameters[11] = new SqlParameter("UserId", investorInfo["UserId"]);

            if (investorData.Insert(parameters))
                return true;
            else
                return false;
        }

        public DataTable GetSingleInvestor(Dictionary<string, int> memberInformation)
        {
            SqlParameter[] parameters = new SqlParameter[memberInformation.Count];
            parameters[0] = new SqlParameter("InvestorId", memberInformation["InvestorId"]);
            DataTable dataTable = new DataTable();
            dataTable = investorData.GetSingleInvestor(parameters);
            return dataTable;
        }

        public DataTable GetAllInvestor()
        {
            DataTable allInvestorTable = new DataTable();
            allInvestorTable = investorData.GetAllInvestors();
            return allInvestorTable;
        }
    }
}
