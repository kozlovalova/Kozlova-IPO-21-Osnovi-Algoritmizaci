using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в мою новеллу: ПОИСК ЗАРЯДКИ ДЛЯ НОУТА!");
        Console.WriteLine("Ты - это я(Соня). Твой ноутбук почти разряжен. Нужно найти зарядку, пока он не выключился!");
        Console.WriteLine("Нажми Enter, чтобы начать...");
        Console.ReadLine();

        // Шаг 1
        Console.WriteLine("Ты стоишь в комнате. Где искать?");
        Console.WriteLine("1 - На столе");
        Console.WriteLine("2 - Под кроватью");
        string step1 = Console.ReadLine();

        if (step1 == "1")
        {
            Console.WriteLine("На столе только книги и кружка с чаем. Зарядки нет.");
            Console.WriteLine("Пойти дальше?");
            Console.WriteLine("1 - Посмотреть в шкафу");
            Console.WriteLine("2 - Проверить рюкзак");
            string step2 = Console.ReadLine();

            if (step2 == "1")
            {
                Console.WriteLine("В шкафу куча одежды и проводов... но не зарядка от ноутбука.");
                Console.WriteLine("1 - Проверить ящик стола");
                Console.WriteLine("2 - Проверить за телевизором");
                string step3 = Console.ReadLine();

                if (step3 == "1")
                {
                    Console.WriteLine("Ты нашёл старую зарядку от телефона. Не подходит :(");
                    Console.WriteLine("1 - Проверить под диваном");
                    Console.WriteLine("2 - Проверить в кухне");
                    string step4 = Console.ReadLine();

                    if (step4 == "1")
                    {
                        Console.WriteLine("Под диваном только пыль и носок. Зарядки нет.");
                        Console.WriteLine("Ты устал и пошёл пить чай. Ноут разрядился.");
                        Console.WriteLine("КОНЦОВКА №1 — ты ленивый как и я) ");
                    }
                    else
                    {
                        Console.WriteLine("На кухне, среди кучи проводов, ты видишь зарядку! Это она!");
                        Console.WriteLine("КОНЦОВКА №2 — ура + вайб, подключаемся к парам БЫСТРО");
                    }
                }
                else
                {
                    Console.WriteLine("За телевизором зарядки нет.");
                    Console.WriteLine("1 - Попросить у мамы зарядку");
                    Console.WriteLine("2 - Проверить балкон");
                    string step5 = Console.ReadLine();

                    if (step5 == "1")
                    {
                        Console.WriteLine("Мама сказала, что у нее другая модель ноутбука. Не повезло.");
                        Console.WriteLine("Ты грустно смотришь на выключенный экран.");
                        Console.WriteLine("КОНЦОВКА №3 — это - вайб ");
                    }
                    else
                    {
                        Console.WriteLine("На балконе ты находишь старую коробку от ноутбука...");
                        Console.WriteLine("Внутри зарядка! Работает!");
                        Console.WriteLine("КОНЦОВКА №4 — как она там оказалась?????");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ты открываешь рюкзак...");
                Console.WriteLine("И видишь зарядку! Она всё это время была там!");
                Console.WriteLine("КОНЦОВКА №5 — гений ");
            }
        }
        else if (step1 == "2")
        {
            Console.WriteLine("Под кроватью темно... и страшно.");
            Console.WriteLine("1 - Засунуть руку");
            Console.WriteLine("2 - Включить фонарик");
            string step6 = Console.ReadLine();

            if (step6 == "1")
            {
                Console.WriteLine("Ты нащупал что-то мягкое... Это тапок. Зарядки нет.");
                Console.WriteLine("1 - Проверить в рюкзаке");
                Console.WriteLine("2 - Проверить за кроватью");
                string step7 = Console.ReadLine();

                if (step7 == "1")
                {
                    Console.WriteLine("Ты открыл рюкзак — там всё, кроме зарядки.");
                    Console.WriteLine("Ты грустно ложишься спать.");
                    Console.WriteLine("КОНЦОВКА №1 — ленивый как и я");
                }
                else
                {
                    Console.WriteLine("За кроватью ты находишь провод...");
                    Console.WriteLine("Это не зарядка, а наушники.");
                    Console.WriteLine("Но ты не сдаёшься и идёшь на кухню...");
                    Console.WriteLine("На кухне на столе лежит твоя зарядка!");
                    Console.WriteLine("КОНЦОВКА №2 — ура ");
                }
            }
            else
            {
                Console.WriteLine("Ты посветил фонариком и увидел пыль и носки.");
                Console.WriteLine("1 - Проверить в шкафу");
                Console.WriteLine("2 - Проверить в рюкзаке");
                string step8 = Console.ReadLine();

                if (step8 == "1")
                {
                    Console.WriteLine("В шкафу ничего интересного...");
                    Console.WriteLine("Ты сдаёшься и идёшь отдыхать.");
                    Console.WriteLine("КОНЦОВКА №3 — неповезло ");
                }
                else
                {
                    Console.WriteLine("Ты открываешь рюкзак...");
                    Console.WriteLine("Там зарядка! Она была с тобой всё время!");
                    Console.WriteLine("КОНЦОВКА №5 — гений ");
                }
            }
        }
        else
        {
            Console.WriteLine("Ты ничего не выбрал и ноут сам выключился.");
            Console.WriteLine("КОНЦОВКА №1 — ленивый как и я ");
        }

        Console.WriteLine("\nВаще чотко, спасибо за игру)");
    }
}
