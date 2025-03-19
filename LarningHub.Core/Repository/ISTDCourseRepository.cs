using LarningHub.Core.Data;
using LarningHub.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Repository
{
    public interface ISTDCourseRepository
    {
         List<Stdcourse> GetAllSTDcourse();
         Stdcourse GetSTDcourseByID(int ID);
         void CreateSTDcourse(Stdcourse stdcourse);
         void UpdateSTDcourse(Stdcourse stdcourse);
         void DeleteSTDcourse(int ID);
         List<TotalStudent> TotalCountStudenEachCourse();
    }
}
