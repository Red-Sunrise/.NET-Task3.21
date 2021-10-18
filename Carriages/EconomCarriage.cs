using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class EconomCarriage : Carriage
    {
        public EconomCarriage(string title,int comfortLevel, int passengerAmount, int baggageAmount) : base(comfortLevel, passengerAmount, baggageAmount)
        {
            Title = "Эконом " + base.Title + title;
        }
        public EconomCarriage()
        {
            Title = "Эконом " + base.Title;
            ComfortLevel = 3;
            PassengerAmount = 30;
            BaggageAmount = 20;
        }
    }
}
