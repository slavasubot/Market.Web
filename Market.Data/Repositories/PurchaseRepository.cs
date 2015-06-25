using System.Data.Entity;
//using System.Data.Entity.Migrations;
using System.Linq;
using Market.Data.Contexts;
using Market.Domain.Entities;
namespace Market.Data.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly DomainDbContext _domainDbContext;

        public PurchaseRepository(DomainDbContext domainDbContext)
        {
            _domainDbContext = domainDbContext;
        }

        public IQueryable<Purchase> Get()
        {
            return _domainDbContext.Purchases.AsQueryable();
        }

        public Purchase Get(int id)
        {
            return _domainDbContext.Purchases.Find(id);
        }

        public Purchase Create(Purchase purchase)
        {
            _domainDbContext.Purchases.Add(purchase);
            _domainDbContext.SaveChanges();
            return purchase;
        }

        public Purchase Update(Purchase purchase)
        {
            _domainDbContext.Entry(purchase).State = EntityState.Modified;
            //_domainDbContext.Purchases.AddOrUpdate(purchase);
            _domainDbContext.SaveChanges();
            return purchase;
        }

        public void Delete(Purchase purchase)
        {
            _domainDbContext.Purchases.Remove(purchase);
            _domainDbContext.SaveChanges();
        }
    }
}
