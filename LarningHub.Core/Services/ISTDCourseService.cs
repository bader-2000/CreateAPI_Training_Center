using LarningHub.Core.Data;
using LarningHub.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Services
{
    public interface ISTDCourseService
    {
        public List<Stdcourse> GetAllSTDcourse();
        public Stdcourse GetSTDcourseByID(int ID);
        public void CreateSTDcourse(Stdcourse stdcourse);
        public void UpdateSTDcourse(Stdcourse stdcourse);
        public void DeleteSTDcourse(int ID);
        public List<TotalStudent> TotalCountStudenEachCourse();
    }
}
