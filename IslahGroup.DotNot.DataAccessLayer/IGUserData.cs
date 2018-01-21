using IslahGroup.DotNet.EntityLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public class IGUserData
    {
        public IGUser GetUserInformation(SqlParameter[] parameters)
        {
            IGUser user = null;
            string connectionString = @"Server=DESKTOP-GBBLD7C\SQLEXPRESS;Database=IslahGroup;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand
            {
                CommandText = "GetUserInformation",
                CommandType = CommandType.StoredProcedure,
                Connection = connection
            };

            command.Parameters.AddRange(parameters);

            DataTable userTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return user;
        }
    }
}
