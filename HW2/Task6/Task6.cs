//Геннадий Приказчиков

//6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.

using System;

namespace Task6
{
    class Task6
    {
        static long Numbers(long a, long b)
        {
            long i = 0,i1 =0, num = 0;

            do
            {
                num = a;

                while (num != 0)
                {
                    num /= 10;
                    i1++;
                }

                if (a % i1 == 0)
                {
                    i++;
                }
                a++;
                i1 = 0;
            }
            while (a != b);

            return i;
        }
        static void Main()
        {
            DateTime start = DateTime.Now;

            Console.WriteLine($"Количество 'хороших' чисел равно: {Numbers(1, 1000000000)}");

            DateTime finish = DateTime.Now;
            TimeSpan timespan = finish - start;

            Console.WriteLine(timespan);

            Console.ReadKey();
        }
    }
}
