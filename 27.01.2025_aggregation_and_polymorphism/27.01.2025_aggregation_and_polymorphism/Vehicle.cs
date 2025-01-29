using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_aggregation_and_polymorphism
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Vehicle(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"{Name} движется со скоростью {Speed} км/ч.");
        }
    }
}
