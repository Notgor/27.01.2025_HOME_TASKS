using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_aggregation_and_polymorphism
{
    public class Boat : Vehicle
    {
        public Engine BoatEngine { get; set; }

        public Boat(string name, int speed, Engine engine) : base(name, speed)
        {
            BoatEngine = engine;
        }

        public override void Drive()
        {
            Console.WriteLine($"Лодка {Name} с двигателем {BoatEngine.Horsepower} л.с. плывет по воде со скоростью {Speed} км/ч.");
        }
    }
}
