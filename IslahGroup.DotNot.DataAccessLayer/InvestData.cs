using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class InvestData: IDatabaseAccessable
    {
        public DataTable GetInvestTypes()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetInvestTypes";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void AddNewInvestType(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_NewInvestType";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();
        }
        public DataTable GetInvestsByInvestor(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetInvestsByInvestor";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public bool Insert(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_InsertNewInvest";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }
        public bool Update(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_UpdateInvest";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }
        public bool Delete(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_DeleteInvest";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }
    }
}
