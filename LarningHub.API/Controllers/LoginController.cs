using LarningHub.Core.Data;
using LarningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;

        public LoginController (ILoginService loginService)
        {
            this.loginService = loginService;
        }
        [HttpGet]
        public List<Login> GetAllLogin()
        {
            return loginService.GetAllLogin();
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public Login GetLoginByID(int ID)
        {
            return loginService.GetLoginByID(ID);
        }
        [HttpPost]
        [Route("Create")]
        public void CreateLogin(Login login)
        {
            loginService.CreateLogin(login);
        }
        [HttpPut]
        [Route("update")]
        public void UpdateLogin(Login login)
        {
            loginService.UpdateLogin(login);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteLogin(int ID)
        {
            loginService.DeleteLogin(ID);
        }


    }
}
