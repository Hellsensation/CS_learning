namespace Lesson_7;

using static Methods;

internal class Cow
{
    public string? Sex { get; set; }
    public int? Satiety { get; set; }
    public int? milk {  get;  private set; }
    
    public Cow(int satiety,  string sex)
    {
        Sex = sex;
        Satiety = satiety;
        milk = 0;
        //Ferm ferm = new Ferm();
        //ferm.cows.Add(this);
    }

    public void ToEat(int food)
    {
        Satiety += food;
        milk += 1;
        Print($"Дали корове поесть\nУровень сытости:{Satiety}\nКол-во молока: {milk} литров", ConsoleColor.DarkGreen);
    }

    public void GiveMilk ()
    {
        milk -= 1;
        Print($"Подоили корову\nКол-во молока: {milk} литров", ConsoleColor.Green);
    }

    public Cow DoSex(Cow cow)
    {
        Random random = new Random();
        string cowGender = Convert.ToString((CowSex)random.Next(0, 2));
        if(cow.Sex != Sex)
        {
            Cow newCow = new Cow(satiety: 10, sex: cowGender);
            Print($"Коровы переспали и на свет появился теленок {newCow.Sex}!", ConsoleColor.Yellow);
            return newCow;
        }
        return null;
    }

    public enum CowSex
    {
        male = 0,
        female = 1
    }
}
