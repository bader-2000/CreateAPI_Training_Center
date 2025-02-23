using LarningHub.Core.Data;
using LarningHub.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        
        public List<Student> GetAllStudent()
        {
            return studentService.GetAllStudent();
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public Student GetStudentByID(int ID)
        {
            return studentService.GetStudentByID(ID);
        }
        [HttpPost]
        [Route("create")]
        public void CreateStudent(Student student)
        {
            studentService.CreateStudent(student);
        }

        [HttpPut]
        [Route("update")]
        public void UpdateStudent(Student student)
        {
            studentService.UpdateStudent(student);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteStudent(int ID)
        {
            studentService.DeleteStudent(ID);
        }

        [HttpGet]
        [Route("getFnameLname")]
        public List<Student> displayFNameAndLNameStudent()
        {
            return studentService.displayFNameAndLNameStudent();
        }
        [HttpGet]
        [Route("getbyFname/{fname}")]
        public List<Student> displayStudentByFname(String Fname)
        {
            return studentService.displayStudentByFname(Fname);
        }
        [HttpGet]
        [Route("getbyBirthDate/{student_date}")]
        public List<Student> displayStudentByBirthDate(DateTime student_date)
        {
            return studentService.displayStudentByBirthDate(student_date);
        }
        [HttpGet]
        [Route("getbyinterval/{from_date}/{to_date}")]
        public List<Student> displayStudentbetweenInterval(DateTime from_date, DateTime to_date)
        {
            return studentService.displayStudentbetweenInterval(from_date, to_date);
        }
        [HttpGet]
        [Route("gethighestMark/{NumOfStudent}")]
        public List<Student> displayStudentHighestMarks(int NumOfStudent)
        {
            return studentService.displayStudentHighestMarks(NumOfStudent);
        }
    }
}
