using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_inheritance
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new HourlyEmployee("Alice", 20, 160);
            Employee emp2 = new MonthlyEmployee("Bob", 3000);
            Employee emp3 = new ContractEmployee("Charlie", 5000);

            Console.WriteLine($"{emp1.Name}: ${emp1.CalculateSalary()}");
            Console.WriteLine($"{emp2.Name}: ${emp2.CalculateSalary()}");
            Console.WriteLine($"{emp3.Name}: ${emp3.CalculateSalary()}");
            Console.ReadKey();
        }
     
    }
}
