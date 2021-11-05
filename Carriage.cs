using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carriages
{
    public class Carriage
    {
        public Carriage(int comfortLevel, int passengerAmount, int baggageAmount)
        {
            this.ComfortLevel = comfortLevel;
            this.PassengerAmount = passengerAmount;
            this.BaggageAmount = baggageAmount;
        }

        public int ComfortLevel { get; }

        public int PassengerAmount { get; }

        public int BaggageAmount { get; }
    }
}
