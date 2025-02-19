using LarningHub.Core.Data;
using LarningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleService _roleservice;
        public RoleService(IRoleService roleservice)
        {
            _roleservice = roleservice;
        }

        public void CreateRole(Role role)
        {
            _roleservice.CreateRole(role);
        }

        public void DeleteRole(int ID)
        {
            _roleservice.DeleteRole(ID);
        }

        public List<Role> GetAllRole()
        {
            return _roleservice.GetAllRole();
        }

        public Role GetRoleByID(int ID)
        {
           return _roleservice.GetRoleByID(ID);
        }

        public void UpdateRole(Role role)
        {
            _roleservice.UpdateRole(role);  
        }
    }
}
