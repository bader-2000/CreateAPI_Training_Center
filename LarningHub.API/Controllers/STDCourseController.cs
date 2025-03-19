using LarningHub.Core.Data;
using LarningHub.Core.DTO;
using LarningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class STDCourseController : ControllerBase
    {
        private readonly ISTDCourseService sTDCourseService;
        public STDCourseController(ISTDCourseService sTDCourseService)
        {
            this.sTDCourseService = sTDCourseService;
        }

        [HttpGet]

        public List<Stdcourse> GetAllSTDcourse()
        {
            return sTDCourseService.GetAllSTDcourse();

        }
        [HttpGet]
        [Route("getTotalStudentEachCourse")]
        public List<TotalStudent> TotalCountStudenEachCourse()
        {
            return sTDCourseService.TotalCountStudenEachCourse();
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public Stdcourse GetSTDcourseByID(int ID)
        {
            return sTDCourseService.GetSTDcourseByID(ID);
        }
        [HttpPost]
        [Route("create")]
        public void CreateSTDcourse(Stdcourse stdcourse)
        {
            sTDCourseService.CreateSTDcourse(stdcourse);
        }
        [HttpPut]
        [Route("update")]
        public void UpdateSTDcourse(Stdcourse stdcourse)
        {
            sTDCourseService.UpdateSTDcourse(stdcourse);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteSTDcourse(int ID)
        {
            sTDCourseService.DeleteSTDcourse(ID);

        }
    }
}
