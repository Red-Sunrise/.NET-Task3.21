using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Carriage
    {
        public string Title { get; protected set; }
        public int ComfortLevel { get; protected set; }
        public int PassengerAmount { get; protected set; }
        public int BaggageAmount { get; protected set; }

        public Carriage(int comfortLevel, int passengerAmount, int baggageAmount)
        {
            Title = "Вагон";
            ComfortLevel = comfortLevel;
            PassengerAmount = passengerAmount;
            BaggageAmount = baggageAmount;
        }
        public Carriage()
        {
            Title = "Вагон";
        }

        public override string ToString()
        {
            return Title + 
                "\n Уровень комфорта = " + ComfortLevel +
                "\n Количество пассажиров = " + PassengerAmount +
                "\n Количество багажа = " + BaggageAmount;
        }
    }
}
