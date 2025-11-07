using System;

class Program
{
    static void Main()
    {
        // просим пользователя ввести число
        Console.WriteLine("Введите число:");

        // читаем, что он написал, и превращаем в число
        int number = Convert.ToInt32(Console.ReadLine());

        // проверяем, равно ли число 5 или 10
        if (number == 5 || number == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }

        // чтобы консоль не закрывалась сразу
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}
