using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// Задача 4. Составьте программу вычисления суммы 150 первых членов арифметической прогрессии, если a1= –200; d = 0,2.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = -200;
            double d = 0.2;
            int n = 150;
            double sum = n / 2.0 * (2 * a1 + (n - 1) * d);

            Console.WriteLine($"Sum= {sum}");
            Console.ReadKey();
        }
    }
}
