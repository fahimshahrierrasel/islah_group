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
            dBConn.Close();
            return dataTable;
        }
        public DataTable GetAllImage()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetAllImages";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dBConn.Close();
            return dataTable;
        }
        public DataTable GetAllVideo()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetAllVideos";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dBConn.Close();
            return dataTable;
        }
        public void UploadNewImage(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_UploadImage";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();
        }
        public void UploadNewVideo(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_UploadVideo";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();
        }
    }
}
