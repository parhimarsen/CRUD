using System;
using System.Collections.Generic;
using System.Linq;
using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Services
{
    public class AccountService : IAccountService
    {
        private static List<Account> accounts = new List<Account>()
        {
            new Account(){ NumberOfAccount = "123", AccountId = "1", ClientId = 1},
            new Account(){ NumberOfAccount = "222", AccountId = "2", ClientId = 2},
            new Account(){ NumberOfAccount = "431", AccountId = "3", ClientId = 3},
            new Account(){ NumberOfAccount = "555", AccountId = "4", ClientId = 3}
        };

        public IEnumerable<Account> GetAllAccounts()
        {
            return accounts;
        }

        public Account GetAccount(int? id)
        {
            return accounts.Where(_ => _.AccountId == id.ToString()).FirstOrDefault();
        }

        public IEnumerable<Account> GetAccountsOfClient(int? clientId)
        {
            return accounts.Where(_ => _.ClientId == clientId);
        }

        public Account GetAccountOfClient(int? clientId, int? accountId)
        {
            return GetAccountsOfClient(clientId).Where(_ => _.AccountId == accountId.ToString()).FirstOrDefault();
        }

        public Account CreateAccount(Account acc)
        {
            acc.AccountId = (accounts.Count + 1).ToString();
            accounts.Add(acc);
            return acc;
        }

        public void RemoveAccount(int accountId)
        {
            Account acc = GetAccount(accountId);

            if (acc != null)
            {
                accounts.Remove(acc);
            }
        }

        public bool UpdateAccount(Account acc)
        {
            Account storedAcc = GetAccount(Convert.ToInt16(acc.AccountId));

            if (storedAcc != null)
            {
                storedAcc.NumberOfAccount = acc.NumberOfAccount;
                storedAcc.ClientId = acc.ClientId;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}