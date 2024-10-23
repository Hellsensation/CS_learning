namespace Lesson_7;

using System.Security.Cryptography.X509Certificates;
using static Methods;

class Ferm
{

    public List<Cow> cows = [];
    public List<Chiken> chikens = [];
    public List<Pig> pigs = [];

    public void AnimalFeeding()
    {
        Print("Кормим коров", ConsoleColor.DarkBlue);
        foreach (var cow in cows)
        {
            cow.ToEat(32);
        }
    }

    public void GetEatFromAnimals()
    {
        Print("Получаем у коров молоко", ConsoleColor.DarkCyan);
        foreach (var cow in cows)
        {
            cow.GiveMilk();
        }
    }

    public void AnumalMating()
    {
        Print("Пришло время спариваться у животных", ConsoleColor.Magenta);
        for(int i = 0; i < 1; i++)
        {
            var cow = cows[0].DoSex(cows[1]);
            cows.Add(cow);
        }
    }


}
