using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
///Задача 1. Вывести первые пять членов арифметической прогрессии (с использованием цикла), если a1=1, d=4 (например, 1  5  9  13  17).
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1;
            int d = 4;
            for (int i = 1; i <= 5; i++)
            {
                int an = a1 + (i - 1) * d;
                Console.Write(an + " ");
            }         
            Console.Read();
        }
    }
}
