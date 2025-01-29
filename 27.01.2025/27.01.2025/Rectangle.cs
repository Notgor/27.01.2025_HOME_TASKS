using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(string color, double x, double y, double width, double height)
            : base(color, x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Display()
        {
            Console.WriteLine($"Прямоугольник - Цвет: {color}, Центр: ({x}, {y}), Ширина: {width}, Высота: {height}");
        }
    }

}