using LarningHub.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Repository
{
    public interface ILoginRepository
    {
        public List<Login> GetAllLogin();
        public Login GetLoginByID(int ID);
        public void CreateLogin(Login login);
        public void UpdateLogin(Login login);
        public void DeleteLogin(int ID);
        
    }
}
