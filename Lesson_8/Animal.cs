namespace Lesson_8;

public abstract class Animal
{
    public int? Age;
    public AnimalGender? Sex;
    public int? Satiety;

    public delegate void AnimalBornEventHandler(Animal newAnimal);
    public event AnimalBornEventHandler AnimalBorn;

    public Animal()
    {
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0,2);
    }

    public Animal(int age) 
    {
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }

    public Animal(int age, AnimalGender sex)
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
    public Cow() : base()
    {
        Milk = 0;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Cow(int age) : base(age)
    {
        Milk = 0;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Cow(int age, AnimalGender sex) : base(age, sex)
    {
        Milk = 0;
        Age = age;
        Sex = sex;
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
            Cow newCow = new Cow();
            AnimalBornEvent(newCow);

            return newCow;
        }
        else
        {
            return null;
        }
    }
}

public class Chicken : Animal
{
    public int Eggs { get; set; }

    public Chicken()
    {
        Eggs = 0;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }

    public Chicken(int age) : base(age)
    {
        Eggs = 0;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Chicken(int age, AnimalGender sex) : base(age, sex)
    {
        Eggs = 0;
        Age = age;
        Sex = sex;
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
            Chicken newChicken = new Chicken();
            AnimalBornEvent(newChicken);

            return newChicken;
        }
        else
        {
            return null;
        }
    }
}

public class Pig : Animal
{
    public int Meat { get; set; }


    public Pig() : base()
    {
        Meat = 5;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Pig(int age) : base(age)
    {
        Meat = 5;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Pig(int age, int meat, AnimalGender sex) : base(age, sex)
    {
        Meat = meat;
        Age = age;
        Sex = sex;
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
            Pig newPig = new Pig();
            AnimalBornEvent(newPig);

            return newPig;
        }
        else
        {
            return null;
        }
    }
}



