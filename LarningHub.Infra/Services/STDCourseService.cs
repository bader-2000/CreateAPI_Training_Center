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
    public class STDCourseService : ISTDCourseService
    {
        private readonly ISTDCourseService _stdcourseService;

        public STDCourseService(ISTDCourseService stdcourseService)
        {
            _stdcourseService = stdcourseService;
        }

        public void CreateSTDcourse(Stdcourse stdcourse)
        {
            _stdcourseService.CreateSTDcourse(stdcourse);
        }

        public void DeleteSTDcourse(int ID)
        {
           _stdcourseService.DeleteSTDcourse(ID);
        }

        public List<Stdcourse> GetAllSTDcourse()
        {
            return _stdcourseService.GetAllSTDcourse(); 
        }

        public Stdcourse GetSTDcourseByID(int ID)
        {
           return _stdcourseService.GetSTDcourseByID(ID);
        }

        public void UpdateSTDcourse(Stdcourse stdcourse)
        {
            _stdcourseService.UpdateSTDcourse(stdcourse);
        }
    }
}
