using LarningHub.Core.Common;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Common
{
    public class DBContext : IDBContext
    {
        public DbConnection _connection;
        public readonly IConfiguration _configuration;

        public DBContext(IConfiguration configuration)
        {

            _configuration = configuration;
        }

        public DbConnection Connection
        {
            get
            {    
                if(_connection == null )
                {
                    _connection = new OracleConnection(_configuration["DBAPIConnectionString"]);
                    _connection.Open();
                }
                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }
        
    }
}
