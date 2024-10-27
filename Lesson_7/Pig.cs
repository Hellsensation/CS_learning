namespace Lesson_7;

using static Lesson_7.Chicken;
using static Methods;

internal class Pig
{
    public string? Sex { get; set; }
    public int? Satiety { get; set; }
    public int? Weght { get; private set; }


    public Pig (int satiety, string sex)
    {
        Sex = sex;
        Satiety = satiety;
        Weght = 50;
    }

    public void ToEat(int food)
    {
        Satiety += food;
        Weght += 1;
        Print($"Дали свинье поесть\nУровень сытости:{Satiety}\nЕё вес: {Weght} кг", ConsoleColor.DarkGreen);
    }

    public void GiveMeat()
    {
        Weght -= 1;
        Print($"От свиньи отрезали кусок мяса\nТеперь она весит: {Weght} кг", ConsoleColor.Green);
    }

    public Pig DoSex(Pig pig)
    {
        Random random = new Random();
        string pigGender = Convert.ToString((PigSex)random.Next(0, 2));
        if (pig.Sex != Sex)
        {
            Pig newPig = new Pig(satiety: 10, sex: pigGender);
            Print($"Свиньи переспали и теперь у них будут поросята!", ConsoleColor.Yellow);
            return newPig;
        }
        return null;
    }
    public enum PigSex
    {
        male = 0,
        female = 1
    }
}
