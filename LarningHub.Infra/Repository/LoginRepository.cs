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
    public class LoginRepository : ILoginRepository
    {
        private readonly IDBContext _IdbContext;

        public LoginRepository(IDBContext IdbContext)
        {
            _IdbContext = IdbContext;
        }

        public void CreateLogin(Login login)
        {
            var p = new DynamicParameters();
            p.Add("username",login.Username,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("pass", login.User_Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("roleID", login.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("studentID", login.Studentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("Login_Package.CreateLogin",p,commandType:CommandType.StoredProcedure);

        }

        public void DeleteLogin(int ID)
        {
            var p =new DynamicParameters();
            p.Add("IDl",ID,dbType:DbType.Int64,direction:ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("Login_Package.DeleteLogin",p,commandType:CommandType.StoredProcedure);
        }
        public List<Login> GetAllLogin()
        {
            IEnumerable<Login> result = _IdbContext.Connection.Query<Login>("Login_Package.GetAllLogin", commandType:CommandType.StoredProcedure);
            return result.ToList();
        }
        public Login GetLoginByID(int ID)
        {
            var p = new DynamicParameters();
            p.Add("IDl", ID,dbType:DbType.Int32,direction:ParameterDirection.Input);
            IEnumerable<Login> result = _IdbContext.Connection.Query<Login>
                ("Login_Package.GetLoginByID",p,commandType:CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateLogin(Login login)
        {
            var p = new DynamicParameters();
            p.Add("IDl",login.Loginid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("username",login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass",login.User_Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("roleID",login.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("studentID",login.Studentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("Login_Package.UpdateLogin", p, commandType: CommandType.StoredProcedure);
        }
    }
}
