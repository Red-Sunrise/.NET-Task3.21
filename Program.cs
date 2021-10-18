using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carriage businessCarriage = new BusinessCarriage();
            Console.WriteLine(businessCarriage+"\n");
            Carriage economCarriage = new EconomCarriage();
            Console.WriteLine(economCarriage+"\n");
            Carriage customCarriage = new Carriage(5,10,15);
            Console.WriteLine(customCarriage + "\n");

            Train businessTrain = new BusinessTrain();
            Console.WriteLine(businessTrain);
            Console.WriteLine(" Количество вагонов с 5 пассажирами  = " + businessTrain.GetCarriagesWithCertainPassengerAmount(5).Count);
            Console.WriteLine("");


            Train economTrain = new EconomTrain();
            Console.WriteLine(economTrain);
            Console.WriteLine(" Количество вагонов с 30 пассажирами  = " + economTrain.GetCarriagesWithCertainPassengerAmount(30).Count);
            Console.WriteLine("");

            Train customTrain = new Train();
            customTrain.AddCarriage(4, economCarriage);
            customTrain.AddCarriage(2, businessCarriage);
            customTrain.AddCarriage(3,customCarriage);
            Console.WriteLine(customTrain);
            customTrain.PrintOrderOfCarriages();
            Console.WriteLine("Отсортируем вагоны на основе уровня комфорта");
            customTrain.SortCarriagesByComfortLevel();
            customTrain.PrintOrderOfCarriages();

        }
    }
}
