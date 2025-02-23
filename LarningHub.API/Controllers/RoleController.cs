using LarningHub.Core.Data;
using LarningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        [HttpGet]

        public List<Role> GetAllRole()
        {
            return roleService.GetAllRole();
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public Role GetRoleByID(int ID)
        {
            return roleService.GetRoleByID(ID);
        }
        [HttpPost]
        [Route("create")]
        public void CreateRole(Role role)
        {
            roleService.CreateRole(role);
        }
        [HttpPut]
        [Route("update")]
        public void UpdateRole(Role role)
        {
            roleService.UpdateRole(role);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteRole(int ID)
        {
            roleService.DeleteRole(ID);
        }
    }
}
