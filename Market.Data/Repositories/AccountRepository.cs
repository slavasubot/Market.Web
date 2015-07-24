using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Market.Domain.Entities;
using Market.Data.Contexts;

namespace Market.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DomainDbContext _domainDbContext;

        public AccountRepository(DomainDbContext domainDbContext)
        {
            _domainDbContext = domainDbContext;
        }

        public void CreateAccount(Account account)
        {
            _domainDbContext.Accounts.Add(account);
            _domainDbContext.SaveChanges();
        }

        public List<Account> GetAccounts(User user)
        {
            var accounts = _domainDbContext.Accounts.Where(a => a.UserId == user.Id).ToList();
            return accounts;
        }

        public void DeleteAccount(Account account)
        {
            _domainDbContext.Accounts.Remove(account);
            _domainDbContext.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            _domainDbContext.Entry(account).State = EntityState.Modified;
            _domainDbContext.SaveChanges();
        }

        public Account FindById(int id)
        {
            var account = _domainDbContext.Accounts.Find(id);
            if (account != null)
            {
                return account;
            }
            return null;
        }
    }
}
