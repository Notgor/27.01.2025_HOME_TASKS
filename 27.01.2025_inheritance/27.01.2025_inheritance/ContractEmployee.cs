using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_inheritance
{
    public class ContractEmployee : Employee
    {
        public double FixedAmount { get; set; }

        public ContractEmployee(string name, double fixedAmount)
            : base(name)
        {
            FixedAmount = fixedAmount;
        }

        public override double CalculateSalary()
        {
            return FixedAmount;
        }
    }
}
