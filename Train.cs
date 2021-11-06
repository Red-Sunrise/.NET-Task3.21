using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carriages;

namespace Task3
{
    public class Train
    {
        public Train()
        {
            this.Carriages = new List<Carriage>();
        }
        public List<Carriage> Carriages { get; }
        public int TotalPassengerAmount
        {
            get
            {
                int passengerAmount = 0;
                for (int i = 0; i < Carriages.Count; i++)
                {
                    passengerAmount += Carriages[i].PassengerAmount;
                }
                return passengerAmount;
            }
        }
        public int TotalBaggageAmount
        {
            get 
            {
                int baggageAmount = 0;
                for (int i = 0; i < Carriages.Count; i++)
                {
                    baggageAmount += Carriages[i].BaggageAmount;
                }
                return baggageAmount;
            }
        }
    }
}
