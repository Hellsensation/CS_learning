namespace Lesson_5;

public static class Chicken_2
{
    private static int[,] chikensParams = { { 0, 0 }, { 0, 0 }, { 0, 0 } };
    private static int eggsCount = 0;
    
    private static int daysCount = 1;

    public static void Menu()
    {
        Console.WriteLine("Для запуска игры нажмите любую клавишу, кроме Q\nНажмите Q для выхода из игры ");
        string userInput = Console.ReadLine();
        while (userInput != "q")
        {
            if (isDead())
            {   
                Print($"На {daysCount}-й день все курицы умерли\nGAME OVER", ConsoleColor.Red);
;               return;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"=========== День номер {daysCount} ===========");
            Console.ResetColor();
            Console.WriteLine($"Что делаем?\n1-Покормить курицу\n2-Забрать яйцо\n3-Ничего не делать");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    FeedChickens();
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
            
            Console.WriteLine($"На данный момент живых куриц {chikensParams.GetLength(0)}:\nКол-во яиц - {eggsCount}");
            for(int i = 0; i < chikensParams.GetLength(0); i++)
            {
                Console.WriteLine($"\nУровень сытости курицы {i+1} - {chikensParams[i,0]}");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("====================================");
            Console.ResetColor();


            daysCount++;
            for (int i = 0; i < chikensParams.GetLength(0); i++)
            {
                chikensParams[i, 0] -= 1; // Если курица жива, то каждый новый день уровень ее сыстости падает на 1.
            }
        }
    }

    static void FeedChickens()
    {
        Print("Покормить куриц", ConsoleColor.Cyan);
        for (int i = 0; i < chikensParams.GetLength(0); i++)
        {
            FeedChicken(i);
        }
    }

    static void FeedChicken(int num)
    {
        Print($"Покормить курицу {num+1}.\nСколько дать зерен?\nОт 1 до 3", ConsoleColor.Green);
        string? foodCount = Console.ReadLine();
        bool result = int.TryParse(foodCount, out var count);
        if (result)
        {
            if (count >= 1 & count <= 3)
            {
                chikensParams[num, 0] += count;
                chikensParams[num, 1] += 1;
                eggsCount += chikensParams[num, 1];
            }
            else
            {
                Print("Зерен не меньше одного и не больше трех!!!", ConsoleColor.Red);
                FeedChicken(num-1);
            }
        }
        else
        {
            Print("Введите число, а не текст.", ConsoleColor.Red);
        }
    }

    static void GetEgg()
    {
        if (eggsCount > 0)
        {
            Print("Получить яйцо", ConsoleColor.Green);
            eggsCount -= 1;
        }
        else
        {
            Print("Яиц нет", ConsoleColor.Green);
        }
    }

    static void DoNothing()
    {
        Print("Ничего не делать", ConsoleColor.DarkBlue);
    }
    
    static bool isDead()
    {
        for (int i = chikensParams.GetLength(0) - 1; i >= 0; i--)
        {
            if (chikensParams[i, 0] < 0) 
            {
                Console.WriteLine($"{i + 1} Курица умерла");
                chikensParams = removeChicken(chikensParams, i); 
            }
        }
        
        if (chikensParams.GetLength(0) == 0)
        {
            return true;
        }

        return false;
    }
    
    static int[,] removeChicken(int[,] chikens, int removeIndex)
    {
        int[,] newChickens = new int[chikens.GetLength(0)-1, 2];
        for (int i = 0; i < chikens.GetLength(0); i++)
        {
            if (removeIndex == i)
            {
                continue;
            }

            for (int j = 0; j < chikensParams.GetLength(1); j++)
            {
                newChickens[i, j] = chikens[i, j];
            }
        }
        return newChickens;
    }

    
    static void Print(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}