//Геннадий Приказчиков

//2.Написать метод подсчета количества цифр числа.

using System;

namespace Task2
{
    class Task2
    {
        static int NumberOfDigits()
        {
            int num, i=0;
            
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                num /= 10;
                i++;
            }

            return i;
        }
        static void Main()
        {
            Console.WriteLine("Введите число");
            Console.WriteLine($"В числе содержется {NumberOfDigits()} цифр(ы)");

            Console.ReadKey();
        }
    }
}
