using LarningHub.Core.Data;
using LarningHub.Core.Repository;
using LarningHub.Core.Services;
using LarningHub.Infra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService) 
        {
           this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAllCategory()
        {
            return categoryService.GetAllCategory();
        }
        
        [HttpGet]
        [Route("getbyId/{id}")]
        public Category GetCategoryByID(int ID) 
        {
            return categoryService.GetCategoryByID(ID);
        }
        [HttpPost]
        [Route("Create")]
        public void CreateCategory(Category category)
        {
            categoryService.CreateCategory(category);
        }
        [HttpPut]
        [Route("update")]
        public void UpdateCategory(Category category)
        {
            categoryService.UpdateCategory(category);
        }
        [HttpDelete]
        [Route("deleteByID/{id}")]
        public void DeleteCategory(int ID)
        {
            categoryService.DeleteCategory(ID);
        }

    }
}
