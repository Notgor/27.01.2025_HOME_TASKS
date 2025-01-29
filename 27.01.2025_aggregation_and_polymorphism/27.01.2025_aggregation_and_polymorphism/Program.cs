using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_aggregation_and_polymorphism
{
    internal class Program
    {
        static void Main()
        {
            Engine carEngine = new Engine(150);
            Car myCar = new Car("Toyota", 120, carEngine);

            Bicycle myBicycle = new Bicycle("Giant", 25);

            Engine boatEngine = new Engine(200);
            Boat myBoat = new Boat("Yamaha", 60, boatEngine);

            Vehicle[] vehicles = { myCar, myBicycle, myBoat };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
            Console.ReadKey();
        }
    }
}
