using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_on_the_composition
{
    class Program
    {
    static void Main()
    {
        CPU cpu = new CPU("Intel Core i7", 3.5);
        RAM ram = new RAM(16);
        GPU gpu = new GPU("NVIDIA RTX 3080");

        Computer computer = new Computer(cpu, ram, gpu);

        computer.PowerOn();

        Console.WriteLine("\nНажмите любую клавишу для выключения компьютера...");
        Console.ReadKey();

        computer.PowerOff();
    }
}
}
