using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayey.DBConnection
{
    public class SqlDataAccess
    {
        private readonly string _connetionString;

        public SqlDataAccess()
        {
            _connetionString = "Data Source=LAPTOP-KFDQNCRJ\\SQLEXPRESS;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetSqlConnetion()
        {
            return new SqlConnection( _connetionString );
        }
    }
}
