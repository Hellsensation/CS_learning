namespace Lesson_7;

using static Lesson_7.Cow;
using static Methods;
internal class Chicken
{
    public string? Sex { get; set; }
    public int? Satiety { get; set; }
    public int? Egg { get; private set; }

    public Chicken(int satiety, string sex)
    {
        Sex = sex;
        Satiety = satiety;
        Egg = 0;
    }

    public void ToEat(int food)
    {
        Satiety += food;
        Egg += 1;
        Print($"Дали курице поесть\nУровень сытости:{Satiety}\nКол-во яиц: {Egg} штук", ConsoleColor.DarkGreen);
    }

    public void GiveEggs()
    {
        Egg -= 1;
        Print($"Забрали яйца у курицы\nКол-во яиц: {Egg} штук", ConsoleColor.Green);
    }

    public Chicken DoSex(Chicken chicken)
    {
        Random random = new Random();
        string chickenGender = Convert.ToString((ChickenSex)random.Next(0, 2));
        if (chicken.Sex != Sex)
        {
            Chicken newChicken = new Chicken(satiety: 10, sex: chickenGender);
            Print($"КУрицы переспали и теперь яйца оплодотворены!", ConsoleColor.Yellow);
            return newChicken;
        }
        return null;
    }

    public enum ChickenSex
    {
        male = 0,
        female = 1
    }
}
