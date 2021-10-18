using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Train
    {
        private List<Carriage> CarriagesList { get; set; }
        public string Title { get; protected set; }
        public Train()
        {
            Title = "Поезд : ";
            CarriagesList = new List<Carriage>();
        }

        public void AddCarriage(int CarriageAmount,Carriage TypeCarriage)
        {
            for (int i = 0; i < CarriageAmount; i++)
                {
                    CarriagesList.Add(TypeCarriage);
                }
        }

        public int GetPassengerAmount()
        {
            int passengerAmount = 0;
            for (int i = 0; i < CarriagesList.Count; i++)
            {
                passengerAmount += CarriagesList[i].PassengerAmount;
            }
            return passengerAmount;
        }

        public int GetBaggageAmount()
        {
            int baggageAmount = 0;
            for (int i = 0; i < CarriagesList.Count; i++)
            {
                baggageAmount += CarriagesList[i].BaggageAmount;
            }
            return baggageAmount;
        }

        public int GetCarriagesAmount()
        {
            return CarriagesList.Count;
        }



        public List<Carriage> GetCarriagesWithCertainPassengerAmount(int passengerAmount)
        {
            List<Carriage> list = new List<Carriage>();
            for (int i = 0; i < CarriagesList.Count; i++)
            {
                var currentCarriage = CarriagesList[i];
                if (currentCarriage.PassengerAmount == passengerAmount)
                {
                    list.Add(currentCarriage);
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("\n Вагоны с таким количеством пассажиров отсутствуют");
            }
            return list;
        }

        public void SortCarriagesByComfortLevel()
        {
            //Шейкерная сортировка
            int left = 0;
            int right = CarriagesList.Count - 1;

            while(left < right)
            {

                for (int i = left; i < right; i++)
                {
                if(CarriagesList[i].ComfortLevel < CarriagesList[i + 1].ComfortLevel) 
                    {
                        SwapCarriages(i, i + 1);
                    }
                }
                right--;

                for(int i = right; i > left; i--)
                {
                    if(CarriagesList[i-1].ComfortLevel < CarriagesList[i].ComfortLevel) 
                    {
                        SwapCarriages(i - 1, i);
                    }
                }
                left++;
            }
        }

        public void PrintOrderOfCarriages()
        {
            Console.Write("[ ");
            for (int i = 0; i < CarriagesList.Count; i++)
            {
                var currentCarriage = CarriagesList[i];
                var titleAndComfortLevel = currentCarriage.Title + "(" + currentCarriage.ComfortLevel + ")";
                if (i == CarriagesList.Count - 1)
                {
                    Console.WriteLine(titleAndComfortLevel + " ]");
                }
                else
                {
                    Console.Write(titleAndComfortLevel + ", ");
                }
            }
        }

        private void SwapCarriages(int i,int j)
        {
            var temp = CarriagesList[i];
            CarriagesList[i] = CarriagesList[j];
            CarriagesList[j] = temp;
        }

        public override string ToString()
        {
            return Title +
                "\n Количество вагонов = " + this.GetCarriagesAmount()+
                "\n Количество пассажиров = " + this.GetPassengerAmount() +
                "\n Количество багажа = " + this.GetBaggageAmount();
        }

    }
}
