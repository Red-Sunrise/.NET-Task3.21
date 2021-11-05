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
        private List<Carriage> carriages;

        public Train()
        {
            this.carriages = new List<Carriage>();
        }
        public List<Carriage> GetCarriages()
        {
            return carriages;
        }
    }
}
