using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_on_the_composition
{
    public class CPU
    {
        public string Model { get; }
        public double Frequency { get; } // ГГц

        public CPU(string model, double frequency)
        {
            Model = model;
            Frequency = frequency;
        }

        public void Start()
        {
            Console.WriteLine($"Процессор {Model} ({Frequency} ГГц) запущен.");
        }

        public void Stop()
        {
            Console.WriteLine("Процессор остановлен.");
        }
    }
}
