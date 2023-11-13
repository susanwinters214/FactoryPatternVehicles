
using System.Drawing;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            int numOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine("What type of vehicle do you want to make? Car or Motorcycle?");
                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            }
            while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();

        }
    }
}
