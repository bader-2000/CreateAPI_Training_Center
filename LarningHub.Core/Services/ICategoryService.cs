using LarningHub.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Services
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategory();
        public Category GetCategoryByID(int ID);
        public void CreateCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(int ID);
    }
}
