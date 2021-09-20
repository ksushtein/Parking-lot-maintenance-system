using System;
using System.Collections.Generic;


namespace ParkingSystem
{
    public class Manager
    {
        ClientsBase _clientsBase = new ClientsBase();
        Parking _parking = new Parking();

        public void LoadParkingDatabase()
        {
            _parking.LoadDatabase(_clientsBase);
        }

        public void MakingOrder(string clientsFIO, string carNumber, string mark, string parkingSpaceNumber, DateTime leaseTerm, string clientsDiscount)
        {
            Client client = new Client();
            double discountPercent = GetDiscountInfo(clientsDiscount, clientsFIO);
            client.CreateClient(clientsFIO, carNumber, mark, parkingSpaceNumber, leaseTerm, discountPercent);

            int spaceNumber = Convert.ToInt16(parkingSpaceNumber);
            _parking.OrderSpaceByClient(spaceNumber, client);
        }

        public string CalculateTotalDue(string parkingSpaceNumber, string clientsDiscount, string clientsFIO)
        {
            double discountPercent = GetDiscountInfo(clientsDiscount, clientsFIO);

            int spaceNumber = Convert.ToInt16(parkingSpaceNumber);
            return _parking.CalculateTotalDue(spaceNumber, discountPercent);
        }

        public double GetDiscountInfo(string clientsDiscount, string clientsFIO)
        {
            double discountPercent = 0;
            if (clientsDiscount == "Да! Оформляем")
                discountPercent = 0.15;
            else if (clientsDiscount == "Уже есть дисконтная карта")
                if (_clientsBase.GetClientsBy("ФИО", clientsFIO) != null)
                    discountPercent = _clientsBase.ClientDiscount("ФИО", clientsFIO);

            return discountPercent;
        }

        public bool SpaceIsFree(string parkingSpaceNumber)
        {
            int spaceNumber = Convert.ToInt16(parkingSpaceNumber);
            return _parking.GetSpaceBy(spaceNumber).IsFree();
        }





        public string ShowClientsBySearch(string wayOfSearch, string clientsInfo)
        {
            List<Client> clients = new List<Client>();
            clients = _clientsBase.GetClientsBy(wayOfSearch, clientsInfo);
            return _clientsBase.GetInfo(clients);
        }     





        
        public string ShowClientsBase()
        {
            List<Client> clients = _clientsBase.GetClientsBase();
            return _clientsBase.GetInfo(clients);
        }

        public string ShowDebtors()
        {
            List<Client> debtors = _clientsBase.GetDebtors();
            return _clientsBase.GetInfo(debtors);
        }

        public string[] GetConfigurationOf(string parkingSpaceNumber)
        {
            int spaceNumber = Convert.ToInt16(parkingSpaceNumber);
            string[] spaceConfiguration = _parking.GetSpaceBy(spaceNumber).GetInfo().Split('|');
            return spaceConfiguration;
        }

        public void RemoveClientFromSpace(string parkingSpaceNumber)
        {
            int spaceNumber = Convert.ToInt16(parkingSpaceNumber);
            _parking.RemoveClientFromSpace(spaceNumber);
        }




        public int GetAmountOfFreeSpaces()
        {
            return _parking.GetAmountOfFreeSpaces();
        }

    }
}
