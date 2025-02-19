using LarningHub.Core.Data;
using LarningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentService _studentService;

        public StudentService(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void CreateStudent(Student student)
        {
            _studentService.CreateStudent(student);
        }

        public void DeleteStudent(int ID)
        {
            _studentService.DeleteStudent(ID);
        }

        public List<Student> displayFNameAndLNameStudent()
        {
           return _studentService.displayFNameAndLNameStudent();
        }

        public List<Student> displayStudentbetweenInterval(DateOnly from_date, DateOnly to_date)
        {
            return _studentService.displayStudentbetweenInterval(from_date,to_date);    
        }

        public List<Student> displayStudentByBirthDate(DateOnly student_date)
        {
            return _studentService.displayStudentByBirthDate(student_date);
        }

        public List<Student> displayStudentByFname(string Fname)
        {
            return _studentService.displayStudentByFname(Fname);
        }

        public List<Student> displayStudentHighestMarks(int NumOfStudent)
        {
           return _studentService.displayStudentHighestMarks(NumOfStudent);
        }

        public List<Student> GetAllStudent()
        {
            return _studentService.GetAllStudent();
        }

        public Student GetStudentByID(int ID)
        {
            return _studentService.GetStudentByID(ID);
        }

        public void UpdateStudent(Student student)
        {
            _studentService.UpdateStudent(student); 
        }
    }
}
