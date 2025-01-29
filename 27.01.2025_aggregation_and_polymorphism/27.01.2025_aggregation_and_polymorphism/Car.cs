using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_aggregation_and_polymorphism
{
    public class Car : Vehicle
    {
        public Engine CarEngine { get; set; }

        public Car(string name, int speed, Engine engine) : base(name, speed)
        {
            CarEngine = engine;
        }

        public override void Drive()
        {
            Console.WriteLine($"Автомобиль {Name} с двигателем {CarEngine.Horsepower} л.с. едет по дороге со скоростью {Speed} км/ч.");
        }
    }
}
