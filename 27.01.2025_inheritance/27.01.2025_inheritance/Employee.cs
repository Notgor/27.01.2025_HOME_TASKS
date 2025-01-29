using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_inheritance
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }
        public abstract double CalculateSalary();
    }
}
