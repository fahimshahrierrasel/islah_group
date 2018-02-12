using System;
using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class OwnerData : IDatabaseAccessable
    {
        public bool Delete(SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllMembers()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetAllMembers";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable memberTable = new DataTable();
            memberTable.Load(reader);
            return memberTable;
        }

        public DataTable GetSingleMember(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetSingleMember";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable memberTable = new DataTable();
            memberTable.Load(reader);
            return memberTable;
        }

        public bool Insert(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_InsertNewOwner";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }

        public bool InsertNewDeposit(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_InsertNewDeposit";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }

        public DataTable GetMemberDeposits(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetMemberDeposits";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable memberTable = new DataTable();
            memberTable.Load(reader);
            return memberTable;
        }

        public bool Update(SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
