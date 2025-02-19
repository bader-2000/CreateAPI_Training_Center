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
    public class RoleRepository : IRoleRepository
    {
        private readonly IDBContext _IdbContext;

        public RoleRepository(IDBContext IdbContext)
        {
            _IdbContext = IdbContext;
        }

        public void CreateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("role_name",dbType:DbType.String,direction:ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("Role_Package.CreateRole",p,commandType:CommandType.StoredProcedure);

        }

        public void DeleteRole(int ID)
        {
            var p = new DynamicParameters();
            p.Add("ID", ID ,dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("Role_Package.DeleteRole", p,commandType:CommandType.StoredProcedure);
        }

        public List<Role> GetAllRole()
        {
            IEnumerable<Role> result =_IdbContext.Connection.Query<Role>
                ("Role_Package.GetAllRole", commandType:CommandType.StoredProcedure);
            return result.ToList();
        }

        public Role GetRoleByID(int ID)
        {
            var p = new DynamicParameters();
            p.Add("ID",ID,dbType:DbType.Int32,direction:ParameterDirection.Input);
            IEnumerable<Role> result = _IdbContext.Connection.Query<Role>
                ("Role_Package.GetRoleByID", p,commandType:CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public void UpdateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("ID", dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("role_name", dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("Role_Package.UpdateRole", p, commandType: CommandType.StoredProcedure);

        }
    }
}
