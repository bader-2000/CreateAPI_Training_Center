using LarningHub.Core.Data;
using LarningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;
        public CourseController(ICourseService CourseService) 
        {
            this.courseService = CourseService;
        }
        [HttpGet]
        [Route("getall")]
        public List<Course> GetAllCourse()
        {
            return courseService.GetAllCourse();
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public Course GetCourseByID(int ID) 
        {
            return courseService.GetCourseByID(ID);
        }
        [HttpPost]
        [Route("create")]
        public void CreateCourse(Course course)
        {
            courseService.CreateCourse(course);
        }

        [HttpPut]
        [Route("update")]
        public void UpdateCourse(Course course)
        {
            courseService.UpdateCourse(course);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteCourse(int ID) 
        {
            courseService.DeleteCourse(ID);
        }

        [HttpPost]
        [Route("UploadImage")]
        public Course UploadImage()
        {
            var file =Request.Form.Files[0];
            var fileName =Guid.NewGuid().ToString()+"_"+file.FileName ;
            var fullPath = Path.Combine("Image"+fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Course C = new Course();
            C.Imagename = fileName;
            return C ;
        }

    }
}
