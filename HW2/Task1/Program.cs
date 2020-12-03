//Геннадий Приказчиков

//1. Написать метод, возвращающий минимальное из трех чисел.

using System;

namespace Task1
{
    class Program
    {
        static int Numbers()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                a = b;
            }

            if (a >= c)
            {
                a = c;
            }

            return a;
        }

        static void Main()
        {
            int min;

            Console.WriteLine("Введите 3 числа");

            min = Numbers();

            Console.WriteLine($"Нaименьшее число {min}");

            Console.ReadKey();
        }
    }
}
