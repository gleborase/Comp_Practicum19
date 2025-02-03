using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Задача 2. Вывести первые пять членов арифметической прогрессии (с использованием цикла) и найти их общую сумму, если a1=1, d=4 (например, 1  5  9  13  17, sum=45).
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1;
            int d = 4;
            int n = 5;
            long sum = 0;           
            for (int i = 1; i <= n; i++)
            {
                int currentTerm = a1 + (i - 1) * d;
                Console.Write(currentTerm);
                if (i < n)
                {
                    Console.Write(" ");
                }
                sum += currentTerm;
            }
            Console.WriteLine("\nSum=" + sum);
            Console.Read();
        }
    }
}
