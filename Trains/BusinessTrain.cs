using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class BusinessTrain : Train
    {
        public BusinessTrain() : base()
        {
            Title = "Бизнес Поезд : ";
            AddCarriage(5, new BusinessCarriage());
        }
    }
}
