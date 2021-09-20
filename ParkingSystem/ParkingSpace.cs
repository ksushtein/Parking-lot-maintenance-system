using System;

namespace ParkingSystem
{
    class ParkingSpace
    {
        int _number;
        string _vehicleCategory; //категория авто
        double _price; //цена
        bool _isFree; //свободна
        bool _forDisabled; //для инвалидов
        Client _client;

        public void RentedBy(Client client)
        {
            _client = client;
            _isFree = false;
        }

        public void LoadInitialInstall(int number)
        {
            _number = number;
            GiveDisabledInfo(_number);
            GiveInfoVehicleCathegory(_number);
            GivePrice();
            _isFree = true;
            _client = null;
        }

        public string GetInfo()
        {
            string info = _number.ToString();
            if (_isFree)
                info += "|Свободно";
            else info += "|Занято";
            info += "|" + _vehicleCategory + "|" + Convert.ToString(_price);
            if (_forDisabled)
                info += "|Для инвалидов";
            else
                info += "|Нет льгот";
            return info;
        }

        public bool IsFree()
        {
            return _isFree;
        }
        
        public Client GetClient()
        {
            return _client;
        }

        public double Price()
        {
            return _price;
        }

        void GiveDisabledInfo(int number)
        {
            if (number < 3)
                _forDisabled = true;
            else _forDisabled = false;
        }

        void GiveInfoVehicleCathegory(int number)
        {
            if (number < 18)
                _vehicleCategory = "A/M";
            else _vehicleCategory = "B";
        }

        void GivePrice()
        {
            if (_vehicleCategory == "A/M")
                _price = 1000;
            if (_vehicleCategory == "B")
                _price = 2000;
            if (_forDisabled)
                _price = _price * 0.8;
        }
    }
}
