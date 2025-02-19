using Dapper;
using LarningHub.Core.Common;
using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using System.Data;


namespace LarningHub.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDBContext _IdbContext;

        public CourseRepository(IDBContext IdbContext)
        {
            _IdbContext = IdbContext;
        }
        public List<Course> GetAllCourse()
        {
            IEnumerable<Course> result = _IdbContext.Connection.Query<Course>
                ("course_package.getallcourse", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public Course GetCourseByID(int id) 
        {
            var p = new DynamicParameters();
            p.Add("ID",id,dbType:DbType.Int32,direction: ParameterDirection.Input);
            IEnumerable<Course> result = _IdbContext.Connection.Query<Course>
                ("course_package.getcoursebyid",p,commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
        public void CreateCourse(Course course)
        {
            var p = new DynamicParameters();
            p.Add("course_name",course.Coursename , dbType: DbType.String,direction: ParameterDirection.Input);
            p.Add("image_name" , course.Imagename,dbType : DbType.String,direction: ParameterDirection.Input);
            p.Add("catID", course.Categoryid , dbType:DbType.Int32 , direction:ParameterDirection.Input);
           var result = _IdbContext.Connection.Execute("Course_Package.CreateCourse", p,commandType: CommandType.StoredProcedure );
        }
        public void UpdateCourse(Course course) 
        {
            var p = new DynamicParameters();
            p.Add("ID", course.Courseid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("course_name", course.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image_name", course.Imagename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("catID", course.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var resylt = _IdbContext.Connection.Execute("Course_Package.UpdateCourse", p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteCourse(int id) 
        {
            var p = new DynamicParameters();
            p.Add("ID",id,dbType:DbType.Int32,direction:ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("course_package.deletecourse",p,commandType:CommandType.StoredProcedure);
        }
    }
}
