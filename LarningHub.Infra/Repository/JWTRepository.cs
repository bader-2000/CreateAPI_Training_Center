using Dapper;
using LarningHub.Core.Common;
using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Repository
{
    public class JWTRepository : IJWTRepository
    {
        private IDBContext _context;

        public JWTRepository(IDBContext context)
        {
            _context = context;
        }
        public Login AuthLogin(Login login)
        {
            var p =new DynamicParameters();
            p.Add("User_NAME",login.Username ,dbType:DbType.String,direction:ParameterDirection.Input  );
            p.Add("PASS", login.User_Password, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _context.Connection.Query<Login>("UserLogin", p,commandType:CommandType.StoredProcedure);

            return result.FirstOrDefault();

        }
    }
}
