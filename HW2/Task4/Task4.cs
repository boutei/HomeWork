//Геннадий Приказчиков

//4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

using System;

namespace Task4
{
    class Task4
    {
        static void Login()
        {
            string login;
            int i = 3;

            do
            {
                login = Console.ReadLine();

                if (login == "root")
                {
                    if (Password() == true)
                    {
                        Console.WriteLine("Добро пожаловать!");

                        return;
                    }

                    else
                    {
                        Console.WriteLine("Вы 3 ввели неверный пароль. Доступ запрещен.");

                        return;
                    }
                }
                else
                {
                    i--;

                    Console.WriteLine($"Вы ввели неверный логин. Осталось попыток {i}.");
                }
            }
            while (i > 0);

            Console.WriteLine("Вы 3 ввели неверный логин. Доступ запрещен.");
        }

        static bool Password()
        {
            string password;

            int i = 3;

            do
            {
                password = Console.ReadLine();

                if (password == "GeekBrains")
                {
                    return true;
                }
                else
                {
                    i--;

                    Console.WriteLine($"Вы ввели неверный пароль. Осталось попыток {i}.");
                }
            }
            while (i > 0);                    

            return false;
        }

        static void Main()
        {
            Console.WriteLine("Для авторизации ведите логин и пароль.");

            Login();

            Console.ReadKey();
        }
    }
}
