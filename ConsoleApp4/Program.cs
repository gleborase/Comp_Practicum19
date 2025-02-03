using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{/// <summary>
/// Задача 5. Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить:
/// а) в какой день он пробежит больше 20 км;
/// </summary>
    internal class Program
    {
        static void Main()
        {
            int running = 10;
            double increaseRate = 0.1;
            double distance = running;
            int day = 1;

            while (distance <= 20)
            {
                distance += distance * increaseRate;
                day++;
            }

            Console.WriteLine($"Лыжник пробежит больше 20 км на {day} день.");
            Console.Read();
        }
    }
}
