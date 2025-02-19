using LarningHub.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Services
{
    public interface IRoleService
    {
        public List<Role> GetAllRole();
        public Role GetRoleByID(int ID);
        public void CreateRole(Role role);
        public void UpdateRole(Role role);
        public void DeleteRole(int ID);
    }
}
