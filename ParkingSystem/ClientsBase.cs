using System.Collections.Generic;

namespace ParkingSystem
{
    public class ClientsBase
    {
        List<Client> _clients = new List<Client>();

        public double ClientDiscount(string wayOfSearch, string clientsInfo)
        {
            List<Client> searchedClients = GetClientsBy(wayOfSearch, clientsInfo);
            foreach (Client client in searchedClients)
            {
                if (client.Discount() == 0.15)
                    return 0.15;
            }
            return 0;
        }          
        
        public List<Client> GetClientsBy(string wayOfSearch, string clientsInfo)
        {
            List<Client> searchedClients = new List<Client>();
            _clients.ForEach(client =>
            {
                bool isFound = client.Check(wayOfSearch, clientsInfo);
                if (isFound)
                    searchedClients.Add(client);
            });
            return searchedClients;
        }

        public List<Client> GetDebtors()
        {
            List<Client> debtors = new List<Client>();
            _clients.ForEach(client =>
            {
                if (client.IsDebtor())
                    debtors.Add(client);
            });
            return debtors;
        }

        public string GetInfo(List<Client> clients)
        {
            string clientsInfo = "";

            if (clients.Capacity > 0)
                clients.ForEach(client =>
                {
                    clientsInfo += client.GetInfo() + "\n_________________\n";
                });
            else
                clientsInfo += "В клиентской базе нет информации по запросу";

            return clientsInfo;
        }

        public List<Client> GetClientsBase()
        {
            return _clients;
        }

        public void AddClient(Client client)
        {
            _clients.Add(client);
        }

        public void Remove(Client client)
        {
            _clients.Remove(client);
        }
    }
}
