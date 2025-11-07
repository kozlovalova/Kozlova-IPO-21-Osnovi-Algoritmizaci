using System;

class Program
{
    static void Main()
    {
        // Заголовок
        Console.WriteLine("=== ОПЕРАЦИЯ: НАЙТИ ЗАРЯДКУ ===");
        Console.WriteLine("Ты — Илья. До начала пары 10 минут, батарея ноутбука 5%.");
        Console.WriteLine("Нужно найти зарядку! Куда пойдёшь сначала?");
        Console.WriteLine();

        int battery = 5; // уровень батареи
        int actions = 0; // количество сделанных действий
        bool found = false;

        while (battery > 0 && !found && actions < 20)
        {
            Console.WriteLine("Действие #" + (actions + 1));
            Console.WriteLine("Твои действия?)");
            Console.WriteLine("1 — Проверить за столом");
            Console.WriteLine("2 — Заглянуть в кухню");
            Console.WriteLine("3 — Посмотреть в шкафу");
            Console.WriteLine("4 — Проверить за диваном");
            Console.WriteLine("5 — Поиграть с котом (вдруг подскажет)");
            Console.WriteLine("6 — Взять перекус и подумать");
            Console.WriteLine("7 — Позвонить сестре за советом");
            Console.WriteLine("8 — Проверить корзину с бельём");
            Console.WriteLine("9 — Проверить сумку из универа");
            Console.WriteLine("10 — Сдаться и лечь спать");
            Console.Write("Твой выбор (1–10): ");

            string choice = Console.ReadLine();
            actions++;
            battery--; // каждый шаг тратит заряд

            Console.WriteLine();

            // Варианты исходов (случайные и сюжетные)
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ты полез под кровать, а там пыль фу.. Зарядки нет.");
                    break;
                case "2":
                    Console.WriteLine("На кухне мама варит кофе. Зарядки нет, но стало теплее на душе.");
                    break;
                case "3":
                    Console.WriteLine("В шкафу барахлишко. Зарядка? Нет.");
                    break;
                case "4":
                    Console.WriteLine("За диваном одна из игрушек котика. Никакой зарядки.");
                    break;
                case "5":
                    Console.WriteLine("Кот посмотрел... и убежал на балкон.");
                    break;
                case "6":
                    Console.WriteLine("Ты взял перекус. Минус минута, плюс настроение!");
                    break;
                case "7":
                    Console.WriteLine("Сестра сказала: 'Проверь корзину с бельём!' — может, она права?");
                    break;
                case "8":
                    Console.WriteLine("Ты залез в корзину... И + вайб! Нашёл зарядку!");
                    found = true;
                    break;
                case "9":
                    Console.WriteLine("Ты проверяешь сумку — только тетрадь и ручка((");
                    break;
                case "10":
                    Console.WriteLine("Ты решил, что всё это бессмысленно и лёг спать. Конец.");
                    End(1);
                    return;
                default:
                    Console.WriteLine("Ты просто стоишь и ничего не делаешь. Время уходит...");
                    break;
            }

            Console.WriteLine();

            // Случайные события
            Random rnd = new Random();
            int eventChance = rnd.Next(1, 11); // случайное число от 1 до 10

            if (eventChance == 5)
            {
                Console.WriteLine("Кот внезапно сбил с полки провод... Это зарядка!");
                found = true;
            }
            else if (eventChance == 10)
            {
                Console.WriteLine("Свет мигнул... и выключился. Теперь искать сложнее!");
                battery--;
            }

            Console.WriteLine();
        }

        // Проверка концовок
        if (found)
        {
            int endingType = new Random().Next(1, 11);
            End(endingType);
        }
        else
        {
            Console.WriteLine("Ноутбук погас. Ты не успел найти зарядку.");
            End(2);
        }
    }

    static void End(int type)
    {
        Console.WriteLine();
        Console.WriteLine("=== КОНЦОВКА ===");
        switch (type)
        {
            case 1:
                Console.WriteLine("Ты заснул. Утром нашёл зарядку под подушкой. Но пара уже прошла.");
                break;
            case 2:
                Console.WriteLine("Ноутбук сел. Преподаватель поставил минус за присутствие. Увы.");
                break;
            case 3:
                Console.WriteLine("Ты подключил зарядку — и успел на пару! Победа!");
                break;
            case 4:
                Console.WriteLine("Ты нашёл зарядку, но провод оказался порванным. Эх...");
                break;
            case 5:
                Console.WriteLine("Кот принёс зарядку. Ты герой и кот теперь твой лучший друг.");
                break;
            case 6:
                Console.WriteLine("Ты случайно нашёл две зарядки! Сосед теперь твой должник.");
                break;
            case 7:
                Console.WriteLine("Ты нашёл зарядку, но уже вечер. День прошёл зря, но с опытом!");
                break;
            case 8:
                Console.WriteLine("Ты споткнулся о провод — и понял, что это твоя зарядка. Повезло!");
                break;
            case 9:
                Console.WriteLine("Ты нашёл зарядку и понял, что жизнь не так уж сложна :)");
                break;
            case 10:
                Console.WriteLine("Ты нашёл зарядку, подключил ноут .");
                break;
            default:
                Console.WriteLine("Конец истории.");
                break;
        }
        Console.WriteLine("==============================");
    }
}

