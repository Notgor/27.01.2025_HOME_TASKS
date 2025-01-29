using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_on_the_composition
{
    public class RAM
    {
        public int Capacity { get; } // ГБ

        public RAM(int capacity)
        {
            Capacity = capacity;
        }

        public void Load()
        {
            Console.WriteLine($"Оперативная память ({Capacity} ГБ) загружена.");
        }

        public void Clear()
        {
            Console.WriteLine("Оперативная память очищена.");
        }
    }
}
