using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// Задача 3. Родители ко дню рождения своего сына Андрея решили купить и обновить ему мобильный телефон. Для этого они в первый месяц отложили 100 руб., а в каждый последующий на 50 рублей больше. Какая сумма будет через десять месяцев?
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int money1 = 50;
            int numberOfMonths = 10;
            int totalSavings = 0;

            for (int i = 0; i < numberOfMonths; i++)
            {
                totalSavings += money + i * money1;
            }

            Console.WriteLine($"Общая сумма через {numberOfMonths} месяцев: {totalSavings} руб.");
            Console.Read();
        }
    }
}
