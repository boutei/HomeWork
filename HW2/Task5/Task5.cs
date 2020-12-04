//Геннадий Приказчиков

//5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;

namespace Task5
{
    class Task5
    {
        static double IndexMass(double height, double weight)
        {
            double indexmass;                      
                  
            indexmass = weight / Math.Pow(height, 2);

            return indexmass;
        }

        static void BMI(double height, double weight)
        {
            if (IndexMass(height, weight) > 18.5 && IndexMass(height, weight) < 25)
            {
                Console.WriteLine($"Индекс массы тела равен: {IndexMass(height, weight):F2}. У вас нет проблем с весом.");
            }
            else
            {
                CorrectionBMI(height, weight, IndexMass(height, weight));
                return;
            }

        }

        static void CorrectionBMI(double height, double weight, double bmi)
        {
            double corrbmi;
            if(bmi > 25)
            {
                Console.WriteLine($"Ваш индекс массы тела превышает норму {bmi:F2}");

                corrbmi = (Math.Pow(height, 2) * 25D);

                corrbmi = weight - corrbmi;

                Console.WriteLine($"Для достижения нормы, вам необходимо похудеть хотя бы на {corrbmi:F2} кг.");
            }
            else
            {
                Console.WriteLine($"Ваш индекс массы тела ниже нормы {bmi:F2}");

                corrbmi = (Math.Pow(height, 2) * 18.5D);

                corrbmi -= weight;

                Console.WriteLine($"Для достижения нормы, вам необходимо набрать хотя бы на {corrbmi:F2} кг.");
            }
        }
        static void Main()
        {
            double height, weight;

            Console.WriteLine("Введите рост и вес");

            do
            {
                height = double.Parse(Console.ReadLine());
                weight = double.Parse(Console.ReadLine());
            }
            while (height == 0 || weight == 0 || height < 0 || weight < 0);

            if (height > 2.50)
            {
                height /= 100;
            }

            BMI(height, weight);                                  

            Console.ReadKey();
        }
    }
}
