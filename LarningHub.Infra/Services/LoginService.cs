using LarningHub.Core.Data;
using LarningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginService _loginService;

        public LoginService(ILoginService loginService) 
        {
            _loginService = loginService;   
        }
        public void CreateLogin(Login login)
        {
           _loginService.CreateLogin(login);
        }

        public void DeleteLogin(int ID)
        {
           _loginService.DeleteLogin(ID);
        }

        public List<Login> GetAllLogin()
        {
           return _loginService.GetAllLogin();  
        }

        public Login GetLoginByID(int ID)
        {
            return _loginService.GetLoginByID(ID);
        }

        public void UpdateLogin(Login login)
        {
            _loginService.UpdateLogin(login);
        }
    }
}
