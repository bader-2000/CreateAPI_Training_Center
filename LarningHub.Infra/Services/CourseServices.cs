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
    public class CourseServices : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void CreateCourse(Course course)
        {
            _courseRepository.CreateCourse(course);   
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }

        public List<Course> GetAllCourse()
        {
            return _courseRepository.GetAllCourse();
        }

        public Course GetCourseByID(int id)
        {
            return _courseRepository.GetCourseByID(id);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.UpdateCourse(course);
        }
    }
}
