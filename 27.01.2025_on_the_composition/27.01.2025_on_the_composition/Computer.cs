using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01._2025_on_the_composition
{
    public class Computer
    {
        private CPU _cpu;
        private RAM _ram;
        private GPU _gpu;

        public Computer(CPU cpu, RAM ram, GPU gpu)
        {
            _cpu = cpu;
            _ram = ram;
            _gpu = gpu;
        }

        public void PowerOn()
        {
            Console.WriteLine("Запуск компьютера...");
            _cpu.Start();
            _ram.Load();
            _gpu.Initialize();
            Console.WriteLine("Компьютер включен.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Выключение компьютера...");
            _gpu.Shutdown();
            _ram.Clear();
            _cpu.Stop();
            Console.WriteLine("Компьютер выключен.");
        }

    }
}
