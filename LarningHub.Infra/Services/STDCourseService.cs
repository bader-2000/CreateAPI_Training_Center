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
        private readonly ISTDCourseRepository _sTDCourseRepository;

        public STDCourseService(ISTDCourseRepository sTDCourseRepository)
        {
            _sTDCourseRepository = sTDCourseRepository;
        }

        public void CreateSTDcourse(Stdcourse stdcourse)
        {
            _sTDCourseRepository.CreateSTDcourse(stdcourse);
        }

        public void DeleteSTDcourse(int ID)
        {
           _sTDCourseRepository.DeleteSTDcourse(ID);
        }

        public List<Stdcourse> GetAllSTDcourse()
        {
            return _sTDCourseRepository.GetAllSTDcourse(); 
        }

        public Stdcourse GetSTDcourseByID(int ID)
        {
           return _sTDCourseRepository.GetSTDcourseByID(ID);
        }

        public void UpdateSTDcourse(Stdcourse stdcourse)
        {
            _sTDCourseRepository.UpdateSTDcourse(stdcourse);
        }
    }
}
