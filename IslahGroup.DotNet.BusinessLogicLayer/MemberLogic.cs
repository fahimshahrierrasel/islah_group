using IslahGroup.DotNet.EntityLayer;
using IslahGroup.DotNet.DataAccessLayer;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.BusinessLogicLayer
{
    public class MemberLogic
    {
        public IGUser LoginToTheSystem(string username, string password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("Username", username);
            parameters[1] = new SqlParameter("Password", password);
            MemberData memberData = new MemberData();
            IGUser user = memberData.GetUserInformation(parameters);
            return user;
        }
    }
}
