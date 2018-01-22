﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class MemberData : IDatabaseAccessable
    {
        public bool Delete(SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllData()
        {
            throw new NotImplementedException();
        }

        public bool Insert(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "InserMember";
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
