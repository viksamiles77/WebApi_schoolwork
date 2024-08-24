using Qinshift.EShop.DataAccess.Interface;
using Qinshift.EShop.DomainModels;
using Qinshift.EShop.DTOs.Category;
using Qinshift.EShop.Services.Interface;

namespace Qinshift.EShop.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        //private readonly ICategoryRepository _categoryRepo;

        //public CategoryService(ICategoryRepository categoryRepo)
        //{
        //    _categoryRepo = categoryRepo;
        //}

        private readonly IRepository<Category> _categoryRepo;
        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return _categoryRepo.GetAll().Select(x => new CategoryDto
            { Name = x.Name });
        }

        public CategoryDto GetCategoryById(int id)
        {
            var category = _categoryRepo.GetById(id);
            var categoryDto = new CategoryDto { Name = category.Name };
            return categoryDto;
        }
    }
}