using System.Collections.Generic;
using Market.Domain.Entities;

namespace Market.Data.Repositories
{
    public interface IAccountRepository
    {
        void CreateAccount(Account account);
        List<Account> GetAccounts(User user);
        void DeleteAccount(Account account);
        void UpdateAccount(Account account);
        Account FindById(int id);
    }
}
