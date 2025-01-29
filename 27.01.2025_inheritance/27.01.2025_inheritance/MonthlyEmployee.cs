using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_inheritance
{
    public class MonthlyEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public MonthlyEmployee(string name, double monthlySalary)
            : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
