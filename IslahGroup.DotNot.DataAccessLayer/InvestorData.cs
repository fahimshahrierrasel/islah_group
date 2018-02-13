using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class InvestorData : IDatabaseAccessable
    {
        public bool Delete(SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public DataTable GetSingleInvestor(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetSingleInvestor";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable memberTable = new DataTable();
            memberTable.Load(reader);
            return memberTable;
        }

        public DataTable GetAllInvestors()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetAllInvestors";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public bool Insert(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_InsertNewInvestor";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }

        public bool Update(SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
