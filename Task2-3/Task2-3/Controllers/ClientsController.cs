using System.Collections.Generic;
using System.Web.Http;
using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Controllers
{
    [RoutePrefix("api/clients")]
    public class ClientsController : ApiController
    {
        private IUnitOfWork _service;

        public ClientsController(IUnitOfWork service)
        {
            _service = service;
        }

        // GET api/clients
        [HttpGet]
        [Route("")]
        public IEnumerable<Client> GetAllClients()
        {
            return _service.Clients.GetAllClients();
        }

        // api/clients/1
        [HttpGet]
        [Route("{clientId:int}")]
        public Client GetClient(int? clientId)
        {
            return _service.Clients.GetClient(clientId);
        }

        // api/clients/1/accounts
        [HttpGet]
        [Route("{clientId:int}/accounts")]
        public IEnumerable<Account> GetAllAccountsOfClient(int? clientId)
        {
            return _service.Accounts.GetAccountsOfClient(clientId);
        }

        // api/clients/1/accounts/1
        [HttpGet]
        [Route("{clientId:int}/accounts/{accountId:int}")]
        public Account GetAllAccountOfClient(int? clientId, int? accountId)
        {
            return _service.Accounts.GetAccountOfClient(clientId, accountId);
        }

        // POST api/
        [HttpPost]
        [Route("createclient")]
        public Client PostClient(Client client)
        {
            return _service.Clients.CreateClient(client);
        }

        // PUT api/
        [HttpPut]
        [Route("updateclient")]
        public bool PutClient(Client client)
        {
            return _service.Clients.UpdateClient(client);
        }

        // DELETE api/
        [HttpDelete]
        [Route("deleteclient")]
        public void DeleteClient(int clientId)
        {
            _service.Clients.RemoveClient(clientId);
        }


    }
}
