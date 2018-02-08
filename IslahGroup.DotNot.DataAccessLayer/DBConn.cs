using System.Data;
using System.Data.SqlClient;

namespace IslahGroup.DotNet.DataAccessLayer
{
    class DBConn
    {
        private SqlConnection _connection;
        public SqlCommand Cmd { get; }

        /// <summary>
        /// Create DatabaseConnection and set the connection string.
        /// </summary>
        public DBConn()
        {
            Cmd = new SqlCommand();
            // Hosting Server Information
            _connection = new SqlConnection(@"Data Source=localhost;Integrated Security=False; Database=islahgro_admin; User ID=fahimshahrier; Password=asdfahim25711");
            // Fahim's Desktop Server
            //_connection = new SqlConnection(@"Server=DESKTOP-GBBLD7C\SQLEXPRESS;Database=IslahGroup;Trusted_Connection=True;");
            //_connection = new SqlConnection(@"Server=tcp:treebricksdev.database.windows.net,1433;Initial Catalog=IslahGroup;Persist Security Info=False;User ID=fahimshahrierrasel;Password=fahim1@treebricks;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            Cmd.Connection = _connection;
        }

        /// <summary>
        /// Open Database connection.
        /// </summary>
        /// <returns>Current connection</returns>
        public SqlConnection Open()
        {
            if (_connection.State == ConnectionState.Closed || _connection.State == ConnectionState.Broken)
                _connection.Open();
            return _connection;
        }

        /// <summary>
        /// Close current connection and Clear all the command parameters.
        /// </summary>
        public void Close()
        {
            Cmd.Parameters.Clear();
            _connection.Close();
        }

    }
}
