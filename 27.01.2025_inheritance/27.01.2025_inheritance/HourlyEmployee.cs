using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_inheritance
{
    public class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public HourlyEmployee(string name, double hourlyRate, int hoursWorked)
            : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
