using System.Linq;
using Market.Domain.Entities;

namespace Market.Data.Repositories
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Get();
        Category Get(int id);
        Category Create(Category category);
        Category Update(Category category);
        void Delete(Category category);
    }
}
