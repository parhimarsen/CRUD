using System;
using System.Collections.Generic;
using System.Linq;
using Task2_3.Interfaces;
using Task2_3.Models;

namespace Task2_3.Services
{
    public class ClientService : IClientService
    {
        static List<Client> clients = new List<Client>()
        {
            new Client(){ Name = "Arseny", ClientId = "1" },
            new Client(){ Name = "Pavel", ClientId = "2" },
            new Client(){ Name = "Youra", ClientId = "3" }
        };

        public IEnumerable<Client> GetAllClients()
        {
            return clients;
        }

        public Client GetClient(int? id)
        {
            return clients.Where(_ => _.ClientId == id.ToString()).FirstOrDefault();
        }

        public Client CreateClient(Client client)
        {
            client.ClientId = (clients.Count + 1).ToString();
            clients.Add(client);
            return client;
        }

        public void RemoveClient(int? clientId)
        {
            Client client = GetClient(clientId);

            if (client != null)
            {
                clients.Remove(client);
            }
        }

        public bool UpdateClient(Client client)
        {
            Client storedClient = GetClient(Convert.ToInt16(client.ClientId));

            if (storedClient != null)
            {
                storedClient.Name = storedClient.Name;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}