using IslahGroup.DotNet.EntityLayer;
using IslahGroup.DotNet.DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class IGUserLogic
    {
        IGUserData iGUserData;
        public IGUserLogic()
        {
            iGUserData = new IGUserData();
        }
        public IGUser LoginToTheSystem(Dictionary<string, string> userInformation)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("Email", userInformation["Email"]);
            parameters[1] = new SqlParameter("Password", userInformation["Password"]);
            DataTable userTable = iGUserData.GetLoginInfo(parameters);

            IGUser user = null;
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

            return user;
        }
    }
}
