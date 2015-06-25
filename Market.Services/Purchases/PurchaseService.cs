using System;
using System.Linq;
using Market.Domain.Entities;
using Market.Data.Repositories;

namespace Market.Services.Purchases
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public IQueryable<Purchase> Get()
        {
            return _purchaseRepository.Get();
        }

        public Purchase Get(int id)
        {
            return _purchaseRepository.Get(id);
        }

        public Purchase Create(Purchase purchase)
        {
            purchase.BuyedTime = DateTime.Now;
            _purchaseRepository.Create(purchase);
            return purchase;
        }

        public Purchase Update(Purchase purchase)
        {
            return _purchaseRepository.Update(purchase);
        }

        public void Delete(int id)
        {
            Purchase purchase = _purchaseRepository.Get(id);
            _purchaseRepository.Delete(purchase);
        }
    }
}
