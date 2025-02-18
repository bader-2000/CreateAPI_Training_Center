using Dapper;
using LarningHub.Core.Common;
using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Repository
{
    public class RepositorySTDCourse : IRepositorySTDCourse
    {
        private readonly IDBContext _IdbContext;

        public RepositorySTDCourse(IDBContext IdbContext)
        {
            _IdbContext = IdbContext;
        }

        public void CreateSTDcourse(Stdcourse stdcourse)
        {
            var p = new DynamicParameters();
            p.Add("");
        }

        public void DeleteSTDcourse(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Stdcourse> GetAllSTDcourse()
        {
            throw new NotImplementedException();
        }

        public Stdcourse GetSTDcourseByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateSTDcourse(Stdcourse stdcourse)
        {
            throw new NotImplementedException();
        }
    }
}
