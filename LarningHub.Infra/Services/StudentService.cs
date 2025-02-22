using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using LarningHub.Core.Services;

namespace LarningHub.Infra.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void CreateStudent(Student student)
        {
            _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(int ID)
        {
            _studentRepository.DeleteStudent(ID);
        }

        public List<Student> displayFNameAndLNameStudent()
        {
           return _studentRepository.displayFNameAndLNameStudent();
        }

        public List<Student> displayStudentbetweenInterval(DateTime from_date, DateTime to_date)
        {
            return _studentRepository.displayStudentbetweenInterval(from_date,to_date);    
        }

        public List<Student> displayStudentByBirthDate(DateTime student_date)
        {
            return _studentRepository.displayStudentByBirthDate(student_date);
        }

        public List<Student> displayStudentByFname(string Fname)
        {
            return _studentRepository.displayStudentByFname(Fname);
        }

        public List<Student> displayStudentHighestMarks(int NumOfStudent)
        {
           return _studentRepository.displayStudentHighestMarks(NumOfStudent);
        }

        public List<Student> GetAllStudent()
        {
            return _studentRepository.GetAllStudent();
        }

        public Student GetStudentByID(int ID)
        {
            return _studentRepository.GetStudentByID(ID);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student); 
        }
    }
}
