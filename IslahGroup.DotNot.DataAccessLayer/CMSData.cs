using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace IslahGroup.DotNet.DataAccessLayer
{
    public class CMSData
    {
        public DataTable GetOwnerShortBio()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetOwnersShortBio";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
    }
}
