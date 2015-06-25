using System.Linq;
using Market.Domain.Entities;

namespace Market.Services.Purchases
{
    public interface IPurchaseService
    {
        IQueryable<Purchase> Get();
        Purchase Get(int id);
        Purchase Create(Purchase purchase);
        Purchase Update(Purchase purchase);
        void Delete(int id);
    }
}
