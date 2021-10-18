using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class EconomTrain : Train
    {
        public EconomTrain() : base()
        {
            Title = "Эконом Поезд :";
            AddCarriage(5, new EconomCarriage());
        }
    }
}
