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
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public void CreateLogin(Login login)
        {
            _loginRepository.CreateLogin(login);
        }

        public void DeleteLogin(int ID)
        {
            _loginRepository.DeleteLogin(ID);
        }

        public List<Login> GetAllLogin()
        {
           return _loginRepository.GetAllLogin();  
        }

        public Login GetLoginByID(int ID)
        {
            return _loginRepository.GetLoginByID(ID);
        }

        public void UpdateLogin(Login login)
        {
            _loginRepository.UpdateLogin(login);
        }
    }
}
