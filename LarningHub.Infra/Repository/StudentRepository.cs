using Dapper;
using LarningHub.Core.Common;
using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IDBContext _IdbContext;

        public StudentRepository(IDBContext IdbContext)
        {
            _IdbContext = IdbContext;
        }

        public void CreateStudent(Student student)
        {
            var p = new DynamicParameters();
            p.Add("student_Fname",student.Firstname,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("student_Lname", student.Lastname,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("student_date", student.Dateofbirth,dbType:DbType.DateTime, direction:ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("student_Package.CreateStudent", p,commandType:CommandType.StoredProcedure);
        }

        public void DeleteStudent(int ID)
        {
            var p = new DynamicParameters();
            p.Add("IDs", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute
                ("student_Package.DeleteStudent", p, commandType: CommandType.StoredProcedure);
        }

        public List<Student> displayFNameAndLNameStudent()
        {

            IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.displayFNameAndLNameStudent", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Student> displayStudentbetweenInterval(DateTime from_date, DateTime to_date)
        {
            var p = new DynamicParameters();
            p.Add("from_dateS",from_date.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("to_dateS", to_date.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.displayStudentbetweenInterval", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

      

        public List<Student> displayStudentByBirthDate(DateTime student_date)
        {
            var p = new DynamicParameters();
            p.Add("student_date", student_date.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input); 
            IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.displayStudentByBirthDate", p,commandType:CommandType.StoredProcedure);
            return result.ToList();
        }

     
        public List<Student> displayStudentByFname(string Fname)
        {
            var p = new DynamicParameters();
            p.Add("Fname", Fname, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.displayStudentByFname", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Student> displayStudentHighestMarks(int NumOfStudent)
        {

            var p = new DynamicParameters();
            p.Add("NumOfStudent", NumOfStudent, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.displayStudentHighestMarks", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Student> GetAllStudent()
        {
             IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.GetAllStudent",commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Student GetStudentByID(int ID)
        {
            var p = new DynamicParameters();
            p.Add("IDs", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Student> result = _IdbContext.Connection.Query<Student>
                ("student_Package.GetStudentByID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateStudent(Student student)
        {
            var p = new DynamicParameters();
            p.Add("IDs", student.Studentid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student_Fname", student.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("student_Lname", student.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("student_date", student.Dateofbirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("student_Package.UpdateStudent", p, commandType: CommandType.StoredProcedure);
        }
    }
}
