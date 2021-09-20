using System;

namespace ParkingSystem
{
    public class Client
    {
        string _fio; //фио
        double _discount; //скидка
        string _carMark; //марка
        string _carNumber; //номер авто
        DateTime _leaseTerm; //срок аренды
        string _parkingSpaceNumber;//№ парковочного места

        public bool Check(string wayOfSearch, string clientsInfo)
        {
            if (wayOfSearch == "ФИО")
                return _fio == clientsInfo;
            else if (wayOfSearch == "Номер машины")
                return _carNumber == clientsInfo;
            else if (wayOfSearch == "Номер арендованного места")
                return _parkingSpaceNumber == clientsInfo;
            else return false;
        }

        public void CreateClient(string clientsFIO, string carNumber, string mark, string parkingSpaceNumber, DateTime leaseTerm, double clientsDiscount)
        {
            _fio = clientsFIO;
            _carNumber = carNumber;
            _carMark = mark;
            _parkingSpaceNumber = parkingSpaceNumber;
            _leaseTerm = leaseTerm;
            _discount = clientsDiscount;            
        }

        public double Discount()
        {
            return _discount;
        }

        public string GetInfo()
        {
            return "\nДанные о клиенте:\nФИО: " + _fio + "\nНомер авто: " + _carNumber +
                "\nМарка авто: " + _carMark + "\nДисконт: " + _discount * 100 + "%" +
                "\nМесто на стоянке: "+_parkingSpaceNumber+"\nСрок аренды истекает: " + _leaseTerm.ToLongDateString();
        }

        public string GetFIO()
        {
            return _fio;
        }

        public bool IsDebtor()
        {
            return _leaseTerm.Date <= DateTime.Now.Date;
        }

    }
}
