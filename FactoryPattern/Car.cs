using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {

        public string Color { get; set; } = "white";
        public bool isDrivable { get; set; }

        public int Tires { get; set; } = 4;


        public void Drive()
        {
            Console.WriteLine($"Driving my {Color} car with all {Tires} tires.");
        }

    }
}

