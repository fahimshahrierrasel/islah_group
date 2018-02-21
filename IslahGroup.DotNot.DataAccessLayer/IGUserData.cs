using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class IGUserData
    {
        public DataTable GetLoginInfo(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            DataTable userTable = new DataTable();

            dBConn.Cmd.CommandText = "SP_GetSingleUser";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            userTable.Load(reader);
            dBConn.Close();
            return userTable;
        }
        public DataTable GetSingleUserById(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            DataTable userTable = new DataTable();

            dBConn.Cmd.CommandText = "SP_GetSingleUserById";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            

            userTable.Load(reader);
            dBConn.Close();
            return userTable;
        }
        public DataTable GetUserTypes()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetUserTypes";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;

            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
            

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dBConn.Close();
            return dataTable;
        }

        public DataTable GetAllUser()
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_GetAllIGUser";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;

            dBConn.Open();
            SqlDataReader reader = dBConn.Cmd.ExecuteReader();
           

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dBConn.Close();
            return dataTable;
        }

        public void RegisterNewIGUser(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_AddNewIGUser";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();
        }
        public bool UpdateIGUser(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_UpdateUser";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }
        public bool ChangePassword(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_ChangePassword";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }
        public bool DeleteIGUser(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_DeleteUser";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();

            return true;
        }
        public void AddNewUserType(SqlParameter[] parameters)
        {
            DBConn dBConn = new DBConn();
            dBConn.Cmd.CommandText = "SP_NewUserType";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            dBConn.Open();
            dBConn.Cmd.ExecuteNonQuery();
            dBConn.Close();
        }
    }
}
