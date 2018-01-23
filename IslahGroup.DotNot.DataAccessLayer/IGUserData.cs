using System;
using System.Data;
using System.Data.SqlClient;
using IslahGroup.DotNet.EntityLayer;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class IGUserData
    {
        public IGUser GetUserInformation(SqlParameter[] parameters)
        {
            IGUser user = null;
            DBConn dBConn = new DBConn();

            dBConn.Cmd.CommandText = "GetUserInformation";
            dBConn.Cmd.CommandType = CommandType.StoredProcedure;
            dBConn.Cmd.Parameters.AddRange(parameters);

            DataTable userTable = new DataTable();
            try
            {
                dBConn.Open();
                SqlDataReader reader = dBConn.Cmd.ExecuteReader();
                userTable.Load(reader);
                if (userTable.Rows.Count == 1)
                {
                    user = new IGUser
                    {
                        UserId = Convert.ToInt32(userTable.Rows[0]["UserId"]),
                        AName = userTable.Rows[0]["AName"].ToString(),
                        Email = userTable.Rows[0]["Email"].ToString(),
                        AUsername = userTable.Rows[0]["AUsername"].ToString(),
                        Apassword = userTable.Rows[0]["APassword"].ToString(),
                        UserType = userTable.Rows[0]["UserType"].ToString()
                    };
                }
                else
                {
                    user = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dBConn.Close();
            }

            return user;
        }
    }
}
