﻿using System;
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
    }
}
