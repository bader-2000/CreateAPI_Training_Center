using LarningHub.Core.Data;
using LarningHub.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Infra.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryServices;
        public CategoryService(CategoryService categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public void CreateCategory(Category category)
        {
            _categoryServices.CreateCategory(category);
        }

        public void DeleteCategory(int ID)
        {
           _categoryServices.DeleteCategory(ID);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryServices.GetAllCategory();
        }

        public Category GetCategoryByID(int ID)
        {
            return _categoryServices.GetCategoryByID(ID);   
        }

        public void UpdateCategory(Category category)
        {
            _categoryServices.UpdateCategory(category); 
        }
    }
}
