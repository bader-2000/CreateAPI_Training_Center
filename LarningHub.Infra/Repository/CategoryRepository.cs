using Dapper;
using LarningHub.Core.Common;
using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using LarningHub.Infra.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDBContext _dBContext;
        public CategoryRepository( IDBContext dBContext) 
        {
            _dBContext = dBContext;
        }
        public List<Category> GetAllCategory()
        {
            IEnumerable<Category> result = _dBContext.Connection.Query<Category>
                ("Category_Package.GetAllCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void CreateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("category_name",category.Categoryname,dbType:DbType.String,direction:ParameterDirection.Input);
            var result = _dBContext.Connection.Execute("Category_Package.CreateCategory",p,commandType:CommandType.StoredProcedure);
        }

        public void DeleteCategory(int ID)
        {
            var p = new DynamicParameters();
            p.Add("ID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Connection.Execute("Category_Package.DeleteCategory",p,commandType:CommandType.StoredProcedure);
        }

        public Category GetCategoryByID(int ID)
        {
            var p = new DynamicParameters();
            p.Add("ID",ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Category> result = _dBContext.Connection.Query<Category>
                ("Category_Package.GetCategoryByID",p,commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("ID",category.Categoryid,dbType:DbType.Int32,direction:ParameterDirection.Input);
            p.Add("category_name",category.Categoryname,dbType:DbType.String,direction:ParameterDirection.Input);
            var result = _dBContext.Connection.Execute("Category_Package.UpdateCategory",p,commandType: CommandType.StoredProcedure);
        }
    }
}
