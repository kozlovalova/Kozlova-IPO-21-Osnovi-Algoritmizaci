using System;

class Program
{
    static void Main()
    {
        // Просим пользователя ввести число
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());

        // Проверяем, подходит ли число под условие
        if (num > 5 && num < 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }

        // Чтобы окно не закрылось сразу
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}