using System;

class Program
{
    static void Main()
    {
        // просим ввести сумму вклада
        Console.WriteLine("Введите сумму вклада:");

        // читаем, что написал пользователь, и превращаем это в число с плавающей точкой
        double summa = Convert.ToDouble(Console.ReadLine());

        // создаём переменную для процента
        double procent = 0;

        // проверяем условия
        if (summa < 100)
        {
            procent = 0.05; // 5%
        }
        else if (summa >= 100 && summa <= 200)
        {
            procent = 0.07; // 7%
        }
        else if (summa > 200)
        {
            procent = 0.10; // 10%
        }

        // считаем, сколько будет денег после начисления процентов
        double itog = summa + (summa * procent);

        // выводим результат
        Console.WriteLine("Сумма вклада с процентами: " + itog);

        // чтобы программа не закрывалась сразу
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}
