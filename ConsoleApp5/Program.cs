using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{/// <summary>
/// Задача 5. Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить:
///б) в какой день суммарный пробег за все дни превысит 100 км.
/// </summary>
    internal class Program
    {
        static void Main()
        {
            double distance = 10;
            double totalDistance = 10;
            int day = 1;

            while (totalDistance <= 100)
            {
                day++;
                distance *= 1.1;
                totalDistance += distance;
            }

            Console.WriteLine($"Суммарный пробег превысит 100 км на {day}-й день.");
            Console.Read();
        }
    }
}
