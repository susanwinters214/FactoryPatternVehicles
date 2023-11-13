﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {

       public string Color { get; set; } = "black";
        public bool hasHandbreak { get; set; }

        public int Tires { get; set; } = 2;

        public bool isDrivable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving my {Color} motorcycle with {Tires} tires.");
        }

    }
}

