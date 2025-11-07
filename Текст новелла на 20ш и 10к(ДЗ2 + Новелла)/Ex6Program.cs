using System;

class Program
{
    static void Main()
    {
        // Просим пользователя выбрать операцию
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        // Читаем номер операции
        int operation = Convert.ToInt32(Console.ReadLine());

        // Проверяем, какую операцию выбрал пользователь
        switch (operation)
        {
            case 1:
                Console.WriteLine("Вы выбрали операцию: Сложение");
                break;

            case 2:
                Console.WriteLine("Вы выбрали операцию: Вычитание");
                break;

            case 3:
                Console.WriteLine("Вы выбрали операцию: Умножение");
                break;

            default:
                Console.WriteLine("Операция неопределена");
                break;
        }

        // Чтобы окно не закрылось сразу
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}
