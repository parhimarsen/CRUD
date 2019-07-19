using Task2_3.Interfaces;

namespace Task2_3.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private ClientService clientService;
        private AccountService accountService;

        public IClientService Clients
        {
            get
            {
                if (clientService == null)
                    clientService = new ClientService();
                return clientService;
            }
        }

        public IAccountService Accounts
        {
            get
            {
                if (accountService == null)
                    accountService = new AccountService();
                return accountService;
            }
        }
    }
}