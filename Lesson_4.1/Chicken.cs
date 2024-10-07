using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1;


public static class Chicken
{
    private static int[] chickenParams = new int[2] { 0, 0 }; // первый параметр хранит уровень сытости, второй - кол-во яиц.
    private static int daysCount = 1;

    public static void Menu()
    {
        Console.WriteLine("Для запуска игры нажмите любую клавишу, кроме Q\nНажмите Q для выхода из игры ");
        string userInput = Console.ReadLine();
        while (userInput != "q")
        {
            if (isDead())
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"На {daysCount}-й день курица умерла.\nGAME OVER");
                Console.ResetColor();
                return;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"=========== День номер {daysCount} ===========");
            Console.ResetColor();
            Console.WriteLine($"Что делаем?\n1-Покормить курицу\n2-Забрать яйцо\n3-Ничего не делать");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    FeedChicken();
                    break;
                case "2":
                    GetEgg();
                    break;
                case "3":
                    DoNothing();
                    break;
                default:
                    Console.WriteLine("Введите 1, 2 или 3");
                    break;
            }

            Console.WriteLine($"На данный момент:\nКол-во яиц - {chickenParams[1]}\nУровень сытости курицы - {chickenParams[0]}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("====================================");
            Console.ResetColor();

            daysCount++;
            chickenParams[0] -= 1; // Если курица жива, то каждый новый день уровень ее сыстости падает на 1.
        }

    }

    static void FeedChicken()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Покормить курицу.\nСколько дать зерен?\nОт 1 до 3");
        Console.ResetColor();
        string? foodCount = Console.ReadLine();
        bool result = int.TryParse(foodCount, out var count);
        if (result)
        {
            if (count >= 1 & count <= 3)
            {
                chickenParams[0] += count;
                chickenParams[1] += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Зерен не меньше одного и не больше трех!!!");
                Console.ResetColor();
                FeedChicken();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Введите число, а не текст.");
            Console.ResetColor();
        }
    }

    static void GetEgg()
    {
        if (chickenParams[1] > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Получить яйцо");
            Console.ResetColor();
            chickenParams[1] -= 1;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Яиц нет");
            Console.ResetColor();
        }
    }

    static void DoNothing()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ничего не делать");
        Console.ResetColor();
        chickenParams[0] -= 1;
    }

    static bool isDead()
    {
        if (chickenParams[0] < 0)
        {
            
            return true;
        }
        else
        { 
            return false; 
        }   
    }
}