using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(string color, double x, double y, double radius)
            : base(color, x, y)
        {
            this.radius = radius;
            
        }

        public override void Display()
        {
            Console.WriteLine($"Круг - Цвет: {color}, Центр: ({x}, {y}), Радиус: {radius}");
        }

    }
}
