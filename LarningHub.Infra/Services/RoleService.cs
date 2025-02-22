using LarningHub.Core.Data;
using LarningHub.Core.Repository;
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
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public void CreateRole(Role role)
        {
            _roleRepository.CreateRole(role);
        }

        public void DeleteRole(int ID)
        {
            _roleRepository.DeleteRole(ID);
        }

        public List<Role> GetAllRole()
        {
            return _roleRepository.GetAllRole();
        }

        public Role GetRoleByID(int ID)
        {
           return _roleRepository.GetRoleByID(ID);
        }

        public void UpdateRole(Role role)
        {
            _roleRepository.UpdateRole(role);  
        }
    }
}
