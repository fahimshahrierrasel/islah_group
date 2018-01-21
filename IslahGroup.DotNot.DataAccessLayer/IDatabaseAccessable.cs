using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNot.DataAccessLayer
{
    public interface IDatabaseAccessable
    {
        bool Insert(SqlParameter[] parameters);
        bool Update(SqlParameter[] parameters);
        bool Delete(SqlParameter[] parameters);
        DataTable GetAllData();
    }
}
