using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025
{
    public class Shape
    {
        protected string color;
        protected double x;
        protected double y;

        public Shape(string color, double x, double y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Цвет {color}, Центр ({x},{y})");
        }
    }
}
