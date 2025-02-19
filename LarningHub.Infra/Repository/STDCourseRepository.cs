using Dapper;
using LarningHub.Core.Common;
using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Repository
{
    public class STDCourseRepository : ISTDCourseRepository
    {
        private readonly IDBContext _IdbContext;

        public STDCourseRepository(IDBContext IdbContext)
        {
            _IdbContext = IdbContext;
        }

        public void CreateSTDcourse(Stdcourse stdcourse)
        {
            var p = new DynamicParameters();
            p.Add("student_id",stdcourse.St,dbType:DbType.Int32,direction:ParameterDirection.Input);
            p.Add("Course_Student_ID",stdcourse.Courseid,dbType:DbType.Int32,direction:ParameterDirection.Input);
            p.Add("Mark_Of_STD",stdcourse.Markofsid,dbType:DbType.Int32,direction:ParameterDirection.Input);
            p.Add("dateOfr",stdcourse.Dateofregister,dbType:DbType.Date,direction:ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("STDcourse_Package.CreateSTDcourse", p,commandType:CommandType.StoredProcedure);

        }

        public void DeleteSTDcourse(int ID)
        {
            var p = new DynamicParameters();
            p.Add("IDs", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("STDcourse_Package.DeleteSTDcourse",p,commandType:CommandType.StoredProcedure);
        }

        public List<Stdcourse> GetAllSTDcourse()
        {
            IEnumerable<Stdcourse> result = _IdbContext.Connection.Query<Stdcourse>
                ("STDcourse_Package.GetAllSTDcourse", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Stdcourse GetSTDcourseByID(int ID)
        {
            var p = new DynamicParameters();
            p.Add("IDs",ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Stdcourse> result = _IdbContext.Connection.Query<Stdcourse>
                ("STDcourse_Package.GetSTDcourseByID",p, commandType:CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateSTDcourse(Stdcourse stdcourse)
        {
            var p = new DynamicParameters();
            p.Add("IDs", stdcourse.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student_id", stdcourse.St, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Course_Student_ID", stdcourse.Courseid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Mark_Of_STD", stdcourse.Markofsid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("dateOfr", stdcourse.Dateofregister, dbType: DbType.Date, direction: ParameterDirection.Input);
            var result = _IdbContext.Connection.Execute("STDcourse_Package.UpdateSTDcourse", p, commandType: CommandType.StoredProcedure);

        }
    }
}
