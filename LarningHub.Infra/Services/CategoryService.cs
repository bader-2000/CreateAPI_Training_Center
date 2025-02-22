using LarningHub.Core.Data;
using LarningHub.Core.Repository;
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
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void CreateCategory(Category category)
        {
            _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategory(int ID)
        {
            _categoryRepository.DeleteCategory(ID);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAllCategory();
        }

        public Category GetCategoryByID(int ID)
        {
            return _categoryRepository.GetCategoryByID(ID);   
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.UpdateCategory(category); 
        }
    }
}
