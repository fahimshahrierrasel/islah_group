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
            SqlParameter[] parameters = new SqlParameter[userInformation.Count];
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
                user = null;
            return user;
        }
        public bool RegisterNewIGUser(Dictionary<string, string> newUser)
        {
            SqlParameter[] parameters = new SqlParameter[newUser.Count];
            parameters[0] = new SqlParameter("Name", newUser["Name"]);
            parameters[1] = new SqlParameter("Username", newUser["Username"]);
            parameters[2] = new SqlParameter("Email", newUser["Email"]);
            parameters[3] = new SqlParameter("Password", newUser["Password"]);
            parameters[4] = new SqlParameter("Type", newUser["Type"]);

            iGUserData.RegisterNewIGUser(parameters);
            return true;
        }
        public bool UpdateIGUser(Dictionary<string, string> updateUser)
        {
            SqlParameter[] parameters = new SqlParameter[updateUser.Count];
            parameters[0] = new SqlParameter("FullName", updateUser["FullName"]);
            parameters[1] = new SqlParameter("Username", updateUser["Username"]);
            parameters[2] = new SqlParameter("Email", updateUser["Email"]);
            parameters[3] = new SqlParameter("Password", updateUser["Password"]);
            parameters[4] = new SqlParameter("Type", updateUser["Type"]);
            parameters[5] = new SqlParameter("UserId", updateUser["UserId"]);

            if (iGUserData.UpdateIGUser(parameters))
                return true;
            else
                return false;
        }
        public bool ChangePassword(Dictionary<string, string> updateUser)
        {
            SqlParameter[] parameters = new SqlParameter[updateUser.Count];
            parameters[0] = new SqlParameter("Password", updateUser["Password"]);
            parameters[1] = new SqlParameter("UserId", updateUser["UserId"]);

            if (iGUserData.ChangePassword(parameters))
                return true;
            else
                return false;
        }
        public bool DeleteIGUser(Dictionary<string, string> deleteUser)
        {
            SqlParameter[] parameters = new SqlParameter[deleteUser.Count];
            parameters[0] = new SqlParameter("UserId", deleteUser["UserId"]);

            if (iGUserData.DeleteIGUser(parameters))
                return true;
            else
                return false;
        }
        public bool AddNewUserType(Dictionary<string, string> newType)
        {
            SqlParameter[] parameters = new SqlParameter[newType.Count];
            parameters[0] = new SqlParameter("Type", newType["Type"]);

            iGUserData.AddNewUserType(parameters);
            return true;
        }
        public DataTable GetAllIGUser()
        {
            DataTable users = new DataTable();
            users = iGUserData.GetAllUser();
            return users;
        }
        public DataTable GetSingleUserById(Dictionary<string, int> user)
        {
            SqlParameter[] parameters = new SqlParameter[user.Count];
            parameters[0] = new SqlParameter("UserId", user["UserId"]);
            DataTable users = new DataTable();
            users = iGUserData.GetSingleUserById(parameters);
            return users;
        }
        public DataTable GetUserTypes()
        {
            DataTable userTypes = new DataTable();
            userTypes = iGUserData.GetUserTypes();
            return userTypes;
        }
    }
}
