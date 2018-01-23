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
            _connection = new SqlConnection(@"Server=DESKTOP-GBBLD7C\SQLEXPRESS;Database=IslahGroup;Trusted_Connection=True;");
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
