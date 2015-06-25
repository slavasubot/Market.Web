using System.Linq;
using Market.Domain.Entities;

namespace Market.Data.Repositories
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Get();
        Purchase Get(int id);
        Purchase Create(Purchase purchase);
        Purchase Update(Purchase purchase);
        void Delete(Purchase purchase);
    }
}
