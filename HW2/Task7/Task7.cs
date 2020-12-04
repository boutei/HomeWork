//Геннадий Приказчиков

//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//   б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;

namespace Task7
{
    class Task7
    {
        static void Loop(int a, int b)
        {
            Console.Write($"{a} ");

            if (a < b)
            {
                Loop(a + 1, b);
            }
        }

        static int SumNumbers(int a, int b, int sum)
        {
            if (a <= b)
            {                
                sum = sum + a;
                a++;
               return SumNumbers(a, b, sum);
            }
            return sum;
        }
        static void Main()
        {
            int a, b, sum = 0;
            
            Console.WriteLine("Введи 2 числа. Первое число должно быть меньше второго.");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Loop(a, b);

            Console.WriteLine();
            Console.WriteLine($"Сумма чисел от a до b равна {SumNumbers(a, b, sum)}");

            Console.ReadKey();
        }
    }
}
