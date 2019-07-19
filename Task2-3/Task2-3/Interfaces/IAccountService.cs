using System.Collections.Generic;
using Task2_3.Models;

namespace Task2_3.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();

        Account GetAccount(int? id);

        IEnumerable<Account> GetAccountsOfClient(int? clientId);

        Account GetAccountOfClient(int? clientId, int? accountId);

        Account CreateAccount(Account client);

        void RemoveAccount(int accountId);

        bool UpdateAccount(Account client);
    }
}
