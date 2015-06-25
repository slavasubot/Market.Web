using System.Data.Entity;
//using System.Data.Entity.Migrations;
using System.Linq;
using Market.Domain.Entities;
using Market.Data.Contexts;

namespace Market.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DomainDbContext _domainDbContext;

        public CategoryRepository(DomainDbContext domainDbContext)
        {
            _domainDbContext = domainDbContext;
        }
        public IQueryable<Category> Get()
        {
            return _domainDbContext.Categories.AsQueryable();
        }

        public Category Get(int id)
        {
            return _domainDbContext.Categories.Find(id);
        }

        public Category Create(Category category)
        {
            _domainDbContext.Categories.Add(category);
            _domainDbContext.SaveChanges();
            return category;
        }

        public Category Update(Category category)
        {
            _domainDbContext.Entry(category).State = EntityState.Modified;
            //_domainDbContext.Categories.AddOrUpdate(category);
            _domainDbContext.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
            _domainDbContext.Categories.Remove(category);
            _domainDbContext.SaveChanges();
        }
    }
}
