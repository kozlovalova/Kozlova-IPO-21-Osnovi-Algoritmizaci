using System;

class Program
{
    static void Main()
    {
        // просим пользователя ввести сумму вклада
        Console.WriteLine("Введите сумму вклада:");

        // читаем введённое число (вклад)
        double summa = Convert.ToDouble(Console.ReadLine());

        // переменная для процента
        double procent = 0;

        // если вклад меньше 100, процент = 5%
        if (summa < 100)
        {
            procent = 0.05;
        }
        // если вклад от 100 до 200, процент = 7%
        else if (summa >= 100 && summa <= 200)
        {
            procent = 0.07;
        }
        // если вклад больше 200, процент = 10%
        else if (summa > 200)
        {
            procent = 0.10;
        }

        // считаем сумму с процентами
        double itog = summa + (summa * procent);

        // добавляем бонус 15 единиц
        double bonus = 15;
        itog = itog + bonus;

        // выводим результат
        Console.WriteLine("Сумма вклада с процентами и бонусом: " + itog);

        // чтобы окно не закрылось сразу
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}
