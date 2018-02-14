using IslahGroup.DotNet.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
