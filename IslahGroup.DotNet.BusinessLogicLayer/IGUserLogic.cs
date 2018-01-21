using IslahGroup.DotNet.EntityLayer;
using IslahGroup.DotNet.DataAccessLayer;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class IGUserLogic
    {
        public IGUser LoginToTheSystem(string username, string password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("Username", username);
            parameters[1] = new SqlParameter("Password", password);
            IGUserData memberData = new IGUserData();
            IGUser user = memberData.GetUserInformation(parameters);
            return user;
        }
    }
}
