using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_on_the_composition
{
    public class GPU
    {
        public string Model { get; }

        public GPU(string model)
        {
            Model = model;
        }

        public void Initialize()
        {
            Console.WriteLine($"Графический процессор {Model} инициализирован.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Графический процессор отключен.");
        }
    }
}
