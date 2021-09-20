using System;

namespace ParkingSystem
{
    class Parking
    {
        ClientsBase _clientsBase;
        ParkingSpace[] _spaces = new ParkingSpace[24];

        public void LoadDatabase(ClientsBase clientsBase)
        {
            for (int number = 0; number < _spaces.Length; number++)
            {
                _spaces[number] = new ParkingSpace();
                _spaces[number].LoadInitialInstall(number);
            }
            _clientsBase = clientsBase;
        }

        public ParkingSpace GetSpaceBy(int spaceNumber)
        {
            return _spaces[spaceNumber];
        }

        public void OrderSpaceByClient(int spaceNumber, Client client)
        {
            _clientsBase.AddClient(client);
            _spaces[spaceNumber].RentedBy(client);
        }

        public string CalculateTotalDue(int parkingSpaceNumber, double discountPercent)
        {
            return (GetSpaceBy(parkingSpaceNumber).Price() * (1 - discountPercent)).ToString();
        }

        public void RemoveClientFromSpace(int spaceNumber)
        { 
            Client removedClient = new Client();
            removedClient = _spaces[Convert.ToInt16(spaceNumber)].GetClient();
            _clientsBase.Remove(removedClient);

            _spaces[spaceNumber].LoadInitialInstall(spaceNumber);
        }

        public int GetAmountOfFreeSpaces()
        {
            int counter = 0;
            for (int number = 0; number < _spaces.Length; number++)
            {
                if (_spaces[number].IsFree())
                    counter++;
            }
            return counter;
        }

    }
}
