using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_aggregation_and_polymorphism
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string name, int speed) : base(name, speed) { }

        public override void Drive()
        {
            Console.WriteLine($"Велосипед {Name} движется по велосипедной дорожке со скоростью {Speed} км/ч.");
        }
    }
}
