namespace Lesson_4;

public static class Chicken
{
    private static int[] chickenParams = new int[2]{0, 0};
    private static int daysCount = 1;
    
    public static void Menu()
    {
        string userInput = Console.ReadLine();
        while (userInput != "q")
        {
            Console.WriteLine($"============ День номер {daysCount} ============");
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

            daysCount++;

            Console.WriteLine($"На данный момент:\nКол-во яиц - {chickenParams[1]}\nУровень сытости курицы - {chickenParams[0]}");
            Console.WriteLine("====================================");

            
        }

    }

    static void FeedChicken()
    {
        Console.WriteLine("Покормить курицу");
        chickenParams[0]+= 1;
        chickenParams[1]+= 1;

    }

    static void GetEgg()
    {
        if (chickenParams[1] > 0)
        {
            Console.WriteLine("Получить яйцо");
            chickenParams[1]-=1;
        }
        else
        {
            Console.WriteLine("Яиц нет");
        }

    }

    static void DoNothing()
    {
        Console.WriteLine("Ничего не делать");
    }

    static void ChickenDead()
    {
        Console.WriteLine("Курица умерла");
    }
    
}