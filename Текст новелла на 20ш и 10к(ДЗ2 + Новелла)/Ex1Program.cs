using System;

class Program
{
    static void Main()
    {
        // просим пользователя ввести первое число
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // просим пользователя ввести второе число
        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // сравниваем числа
        if (num1 == num2)
        {
            Console.WriteLine("Оба числа равны!");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("Первое число больше второго!");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго!");
        }

        // чтобы консоль не закрылась сразу
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

