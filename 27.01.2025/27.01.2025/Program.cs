using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle("Красный", 0, 0, 5),
                new Rectangle("Синий", 10, 15, 20, 10),
                new Triangle("Зеленый", -5, 5, 8, 12)
            };

            foreach (var shape in shapes)
            {
                shape.Display();
                Console.WriteLine();
            }
        }
    }
}
