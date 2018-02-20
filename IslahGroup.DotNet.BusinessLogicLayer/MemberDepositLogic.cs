using IslahGroup.DotNet.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class MemberDepositLogic
    {
        MemberDepositData memberDepositData;
        public MemberDepositLogic()
        {
            memberDepositData = new MemberDepositData();
        }
        public bool AddDeposit(Dictionary<string, string> depositInformation)
        {
            SqlParameter[] parameters = new SqlParameter[depositInformation.Count];
            parameters[0] = new SqlParameter("DepositDate", DateTime.Parse(depositInformation["DepositDate"]).Date);
            parameters[1] = new SqlParameter("Amount", depositInformation["Amount"]);
            parameters[2] = new SqlParameter("Note", depositInformation["Note"]);
            parameters[3] = new SqlParameter("MemberId", depositInformation["MemberId"]);
            parameters[4] = new SqlParameter("UserId", depositInformation["UserId"]);
            memberDepositData.Insert(parameters);
            return true;
        }
        public DataTable GetMemberDeposits(Dictionary<string, int> memberInformation)
        {
            SqlParameter[] parameters = new SqlParameter[memberInformation.Count];
            parameters[0] = new SqlParameter("MemberId", memberInformation["MemberId"]);
            DataTable singleOwnerTable = new DataTable();
            singleOwnerTable = memberDepositData.GetMemberDeposits(parameters);
            return singleOwnerTable;
        }
        public DataTable GetADeposit(Dictionary<string, int> depositInfo)
        {
            SqlParameter[] parameters = new SqlParameter[depositInfo.Count];
            parameters[0] = new SqlParameter("DepositId", depositInfo["DepositId"]);
            DataTable depositTable = new DataTable();
            depositTable = memberDepositData.GetADeposit(parameters);
            return depositTable;
        }
        public bool UpdateDeposit(Dictionary<string, string> depositInformation)
        {
            SqlParameter[] parameters = new SqlParameter[depositInformation.Count];
            parameters[0] = new SqlParameter("DepositDate", DateTime.Parse(depositInformation["DepositDate"]).Date);
            parameters[1] = new SqlParameter("Amount", Double.Parse(depositInformation["Amount"]));
            parameters[2] = new SqlParameter("Note", depositInformation["Note"]);
            parameters[3] = new SqlParameter("MemberId", depositInformation["MemberId"]);
            parameters[4] = new SqlParameter("DepositId", depositInformation["DepositId"]);

            if (memberDepositData.Update(parameters))
                return true;
            else
                return false;
        }
        public bool DeleteDeposit(Dictionary<string, int> depositInformation)
        {
            SqlParameter[] parameters = new SqlParameter[depositInformation.Count];
            parameters[0] = new SqlParameter("MemberId", depositInformation["MemberId"]);
            parameters[1] = new SqlParameter("DepositId", depositInformation["DepositId"]);

            if (memberDepositData.Delete(parameters))
                return true;
            else
                return false;
        }
    }
}
