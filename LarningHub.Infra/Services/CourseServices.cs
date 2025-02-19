using LarningHub.Core.Data;
using LarningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Services
{
    public class CourseServices : ICourseService
    {
        private readonly ICourseService _courseServices;
        public CourseServices(ICourseService courseServices)
        {
            _courseServices = courseServices;
        }
        public void CreateCourse(Course course)
        {
            _courseServices.CreateCourse(course);   
        }

        public void DeleteCourse(int id)
        {
            _courseServices.DeleteCourse(id);
        }

        public List<Course> GetAllCourse()
        {
            return _courseServices.GetAllCourse();
        }

        public Course GetCourseByID(int id)
        {
            return _courseServices.GetCourseByID(id);
        }

        public void UpdateCourse(Course course)
        {
            _courseServices.UpdateCourse(course);
        }
    }
}
