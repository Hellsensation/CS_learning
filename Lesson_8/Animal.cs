namespace Lesson_8;


public abstract class Animal 
{
    public int? Age;
    public AnimalGender? Sex;
    public int? Satiety;
    public readonly ILogger _logger;

    public delegate void AnimalBornEventHandler(Animal newAnimal);
    public event AnimalBornEventHandler AnimalBorn;


    public Animal(ILogger logger)
    {
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0,2);
        _logger = logger;
    }

    public Animal(int age, ILogger logger) 
    {
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }

    public Animal(int age, AnimalGender sex, ILogger logger)
    {
        Age = age;
        Sex = sex;
    }

    public void ToEat(int food)
    {
        Satiety += food;
    }

    public abstract int GiveEat();


    public abstract Animal DoSex(Animal animal);

    protected void AnimalBornEvent(Animal newborn)
    {
        AnimalBorn?.Invoke(newborn);
    }
}


public class Cow : Animal
{
    public int Milk { get; set;}
    public readonly ILogger _logger;
    public Cow(ILogger logger) : base(logger)
    {
        Milk = 0;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
        _logger = logger;
    }
    public Cow(int age, ILogger logger) : base(age, logger)
    {
        Milk = 0;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
        _logger = logger;
    }
    public Cow(int age, AnimalGender sex, ILogger logger) : base(age, sex, logger)
    {
        Milk = 0;
        Age = age;
        Sex = sex;
        _logger = logger;
    }

    public override int GiveEat()
    {
        int tempMilk = Milk;
        Milk = 0;
        return tempMilk;
    }

    public override Animal DoSex(Animal partner)
    {
        if (partner is Cow && partner.Sex != Sex)
        {

            Cow newCow = new Cow(new ConsoleLogger());
            AnimalBornEvent(newCow);

            return newCow;
        }
        else
        {
            return null;
        }
    }
    public void PrintInfo()
    {
        _logger.Print($"Возраст: {Age}\nПол: {Sex}\nУровень сытости: {Satiety}\nМолока у коровы: {Milk}");
    }

}

public class Chicken : Animal
{
    public int Eggs { get; set; }
    public readonly ILogger _logger;

    public Chicken(ILogger logger) : base(logger)
    {
        Eggs = 0;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
        _logger = logger;
    }

    public Chicken(int age, ILogger logger) : base(age, logger)
    {
        Eggs = 0;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
        _logger = logger;
    }
    public Chicken(int age, AnimalGender sex, ILogger logger) : base(age, sex, logger)
    {
        Eggs = 0;
        Age = age;
        Sex = sex;
        _logger = logger;
    }

    public override int GiveEat()
    {
        int tempEggs = Eggs;
        Eggs = 0;
        return tempEggs;
    }

    public override Animal DoSex(Animal partner)
    {
        if (partner is Chicken && partner.Sex != Sex)
        {
            Chicken newChicken = new Chicken(new ConsoleLogger());
            AnimalBornEvent(newChicken);

            return newChicken;
        }
        else
        {
            return null;
        }
    }

    public void PrintInfo()
    {
        _logger.Print($"Возраст: {Age}\nПол: {Sex}\nУровень сытости: {Satiety}\nЯиц у курицы: {Eggs}");
    }
}

public class Pig : Animal
{
    public int Meat { get; set; }
    public readonly ILogger _logger;


    public Pig(ILogger logger) : base(logger)
    {
        Meat = 5;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
        _logger = logger;
    }
    public Pig(int age, ILogger logger) : base(age, logger)
    {
        Meat = 5;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
        _logger = logger;
    }
    public Pig(int age, int meat, AnimalGender sex, ILogger logger) : base(age, sex, logger)
    {
        Meat = meat;
        Age = age;
        Sex = sex;
        _logger = logger;
    }

    public override int GiveEat()
    {
        Age = null;
        Sex = null;
        Satiety = null;
        return Meat;
    }


    public override Animal DoSex(Animal partner)
    {
        if (partner is Pig && partner.Sex != Sex)
        {
            Pig newPig = new Pig(new ConsoleLogger());
            AnimalBornEvent(newPig);

            return newPig;
        }
        else
        {
            return null;
        }
    }

    public void PrintInfo()
    {
        _logger.Print($"Возраст: {Age}\nПол: {Sex}\nУровень сытости: {Satiety}\nМяса в свинье: {Meat}");
    }
}


interface IAnimalInfo
{
    string PrintInfo();
}
