using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025
{
    public class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(string color, double x, double y, double baseLength, double height)
            : base(color, x, y)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override void Display()
        {
            Console.WriteLine($"Треугольник - Цвет: {color}, Центр: ({x}, {y}), Основание: {baseLength}, Высота: {height}");
        }
    }
}
