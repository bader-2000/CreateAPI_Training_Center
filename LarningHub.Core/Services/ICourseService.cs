using LarningHub.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Services
{
    public interface ICourseService
    {
     
        public List<Course> GetAllCourse();
        public Course GetCourseByID(int ID);
        public void CreateCourse(Course course);
        public void UpdateCourse(Course course);
        public void DeleteCourse(int ID);
    }
}
