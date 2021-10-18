using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class BusinessCarriage : Carriage
    {
        public BusinessCarriage(string title,int comfortLevel, int passengerAmount, int baggageAmount) : base(comfortLevel, passengerAmount, baggageAmount)
        {
            Title = "Бизнес " + base.Title + title;
        }
        public BusinessCarriage()
        {
            Title = "Бизнес " + base.Title;
            ComfortLevel = 10;
            PassengerAmount = 5;
            BaggageAmount = 10;
        }
    }
}
