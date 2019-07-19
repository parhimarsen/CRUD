using System.Collections.Generic;
using System.Web.Http;
using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountsController : ApiController
    {
        private IUnitOfWork _service;

        public AccountsController(IUnitOfWork service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Account> GetAllAccounts()
        {
            return _service.Accounts.GetAllAccounts();
        }

        [HttpGet]
        [Route("{accountId:int}")]
        public Account GetAccount(int? accountId)
        {
            return _service.Accounts.GetAccount(accountId);
        }

        // POST api/
        [HttpPost]
        [Route("createaccount")]
        public Account PostAccount(Account account)
        {
            return _service.Accounts.CreateAccount(account);
        }

        // PUT api/
        [HttpPut]
        [Route("updateaccount")]
        public bool PutAccount(Account account)
        {
            return _service.Accounts.UpdateAccount(account);
        }

        // DELETE api/
        [HttpDelete]
        [Route("deleteaccount/{accountId:int}")]
        public void DeleteAccount(int accountId)
        {
            _service.Accounts.RemoveAccount(accountId);
        }
    }
}
