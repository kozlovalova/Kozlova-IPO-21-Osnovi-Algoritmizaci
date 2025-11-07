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

        // Просим ввести два числа
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0; // здесь будет результат

        // Проверяем выбранную операцию
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("Результат сложения: " + result);
                break;

            case 2:
                result = num1 - num2;
                Console.WriteLine("Результат вычитания: " + result);
                break;

            case 3:
                result = num1 * num2;
                Console.WriteLine("Результат умножения: " + result);
                break;

            default:
                Console.WriteLine("Операция неопределена");
                break;
        }

        // Чтобы консоль не закрывалась
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}
