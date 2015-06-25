using System.Linq;
using Market.Domain.Entities;

namespace Market.Services.Categories
{
    public interface ICategoryService
    {
        IQueryable<Category> Get();
        Category Get(int id);
        Category Create(Category category);
        Category Update(Category category);
        void Delete(int id);
    }
}
