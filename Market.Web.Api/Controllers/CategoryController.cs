using System.Web.Http;
using Market.Domain.Entities;
using Market.Services.Categories;

namespace Market.Web.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IHttpActionResult Get()
        {
            return Ok(_categoryService.Get());
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(_categoryService.Get(id));
        }

        public IHttpActionResult Post(Category category)
        {
            return Ok(_categoryService.Create(category));
        }

        public IHttpActionResult Put(Category category)
        {
            return Ok(_categoryService.Update(category));
        }

        public IHttpActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }
    }
    


}
