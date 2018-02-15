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
    }
}
