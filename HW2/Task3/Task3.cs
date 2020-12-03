//Геннадий Приказчиков

//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

using System;

namespace Task3
{
    class Task3
    {       
        static int SumNumber()
        {
            int num, sum = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                
                if (num > 0 && num % 2 != 0)
                {
                    sum += num;
                }
            }
            while (num != 0);

            return sum;
        }
        static void Main()
        {
            Console.WriteLine("Введите числа. Для становки введите 0");

            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {SumNumber()}");

            Console.ReadKey();
        }
    }
}
