using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    public interface IDatabaseAccessable
    {
        bool Insert(SqlParameter[] parameters);
        bool Update(SqlParameter[] parameters);
        bool Delete(SqlParameter[] parameters);
        DataTable GetAllData();
    }
}
