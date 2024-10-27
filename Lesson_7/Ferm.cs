namespace Lesson_7;

using System.Security.Cryptography.X509Certificates;
using static Methods;

class Ferm
{

    public List<Cow> cows = [];
    public List<Chicken> chickens = [];
    public List<Pig> pigs = [];

    


    public void AnimalFeeding()
    {
        Print("Кормим коров", ConsoleColor.DarkBlue);
        foreach (var cow in cows)
        {
            cow.ToEat(32);
        }

        Print("Кормим курей", ConsoleColor.Blue);
        foreach (var chicken in chickens)
        {
            chicken.ToEat(12);
        }

        Print("Кормим свиней", ConsoleColor.Blue);
        foreach (var pig in pigs)
        {
            pig.ToEat(22);
        }

    }

    public void GetEatFromAnimals()
    {
        Print("Получаем у коров молоко", ConsoleColor.DarkCyan);
        foreach (var cow in cows)
        {
            cow.GiveMilk();
        }

        Print("Получаем у кур яйца", ConsoleColor.DarkCyan);
        foreach (var chiken in chickens)
        {
            chiken.GiveEggs();
        }

        Print("Получаем у свиней мясо", ConsoleColor.DarkCyan);
        foreach (var pig in pigs)
        {
            pig.GiveMeat();
        }
    }

    public void AnumalMating()
    {
        Print("Пришло время спариваться у животных", ConsoleColor.Magenta);
        for(int i = 0; i < 1; i++)
        {
            var cow = cows[0].DoSex(cows[1]);
            cows.Add(cow);
            var chicken = chickens[0].DoSex(chickens[1]);
            chickens.Add(chicken);
            var pig = pigs[0].DoSex(pigs[1]);
            pigs.Add(pig);
        }
    }

    public void AnimalCount()
    {
        Print($"На данный момент кол-во животных на ферме:\nКоровы:{cows.Count}\nКуры:{chickens.Count}\nСвиньи{pigs.Count}", ConsoleColor.DarkRed);
    }
}
