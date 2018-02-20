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
    public class InvestLogic
    {
        InvestData investData;
        public InvestLogic()
        {
            investData = new InvestData();
        }
        public DataTable GetInvestType()
        {
            DataTable types = new DataTable();
            types = investData.GetInvestTypes();
            return types;
        }
        public bool AddNewInvestType(Dictionary<string, string> newType)
        {
            SqlParameter[] parameters = new SqlParameter[newType.Count];
            parameters[0] = new SqlParameter("Type", newType["Type"]);
            investData.AddNewInvestType(parameters);
            return true;
        }
        public DataTable GetInvestsByInvestor(Dictionary<string, int> investor)
        {
            SqlParameter[] parameters = new SqlParameter[investor.Count];
            parameters[0] = new SqlParameter("InvestorId", investor["InvestorId"]);
            DataTable investsTable = new DataTable();
            investsTable = investData.GetInvestsByInvestor(parameters);
            return investsTable;
        }
        public DataTable GetAInvest(Dictionary<string, int> investor)
        {
            SqlParameter[] parameters = new SqlParameter[investor.Count];
            parameters[0] = new SqlParameter("InvestId", investor["InvestId"]);
            DataTable investsTable = new DataTable();
            investsTable = investData.GetAInvest(parameters);
            return investsTable;
        }
        public bool InsertNewInvest(Dictionary<string, string> invest)
        {
            SqlParameter[] parameters = new SqlParameter[invest.Count];
            parameters[0] = new SqlParameter("InvestorId", invest["InvestorId"]);
            parameters[1] = new SqlParameter("UserId", invest["UserId"]);
            parameters[2] = new SqlParameter("InvestDate", DateTime.Parse(invest["InvestDate"]).Date);
            parameters[3] = new SqlParameter("Amount", Double.Parse(invest["Amount"]));
            parameters[4] = new SqlParameter("Profit", Double.Parse(invest["Profit"]));
            parameters[5] = new SqlParameter("Note", invest["Note"]);
            parameters[6] = new SqlParameter("Type", invest["Type"]);

            if (investData.Insert(parameters))
                return true;
            else
                return false;
        }
        public bool UpdateInvest(Dictionary<string, string> invest)
        {
            SqlParameter[] parameters = new SqlParameter[invest.Count];
            parameters[0] = new SqlParameter("InvestId", invest["InvestId"]);
            parameters[1] = new SqlParameter("InvestDate", DateTime.Parse(invest["InvestDate"]).Date);
            parameters[2] = new SqlParameter("Amount", Double.Parse(invest["Amount"]));
            parameters[3] = new SqlParameter("Profit", Double.Parse(invest["Profit"]));
            parameters[4] = new SqlParameter("Note", invest["Note"]);

            if (investData.Update(parameters))
                return true;
            else
                return false;
        }
        public bool DeleteInvest(Dictionary<string, int> invest)
        {
            SqlParameter[] parameters = new SqlParameter[invest.Count];
            parameters[0] = new SqlParameter("InvestId", invest["InvestId"]);
            if (investData.Delete(parameters))
                return true;
            else
                return false;
        }
    }
}
