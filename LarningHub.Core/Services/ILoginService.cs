using LarningHub.Core.Data;

namespace LarningHub.Core.Services
{
    public interface ILoginService
    {
        public List<Login> GetAllLogin();
        public Login GetLoginByID(int ID);
        public void CreateLogin(Login login);
        public void UpdateLogin(Login login);
        public void DeleteLogin(int ID);

    }
}
