using System.Collections.Generic;
using Task2_3.Models;

namespace Task2_3.Interfaces
{
    public interface IClientService
    {
        IEnumerable<Client> GetAllClients();

        Client GetClient(int? clientId);

        Client CreateClient(Client client);

        void RemoveClient(int? clientId);

        bool UpdateClient(Client client);

    }
}
