namespace Lesson_8;

public abstract class Animal
{
    public int? Age;
    public AnimalGender? Sex;
    public int? Satiety;

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

    public abstract Animal DoSex(Animal animal);

}


public class Cow : Animal
{
    public int Milk { get; set;}
    public Cow(int milk) : base()
    {
        Milk = milk;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Cow(int age, int milk) : base(age)
    {
        Milk = milk;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Cow(int age, int milk, AnimalGender sex) : base(age, sex)
    {
        Milk = milk;
        Age = age;
        Sex = sex;
    }

    public int GiveMilk()
    {
        int tempMilk = Milk;
        Milk = 0;
        return tempMilk;
    }

    public override Animal DoSex(Animal cow)
    {
        if (cow.Sex != Sex)
        {
            return new Cow(milk: 0);
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
    public Chicken(int eggs) : base()
    {
        Eggs = eggs;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Chicken(int age, int eggs) : base(age)
    {
        Eggs = eggs;
        Age = age;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Chicken(int age, int eggs, AnimalGender sex) : base(age, sex)
    {
        Eggs = eggs;
        Age = age;
        Sex = sex;
    }

    public int GiveEggs()
    {
        int tempEggs = Eggs;
        Eggs = 0;
        return tempEggs;
    }

    public override Animal DoSex(Animal chicken)
    {
        if (chicken.Sex != Sex)
        {
            return new Chicken(eggs: 0);
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
    public Pig(int meat) : base()
    {
        Meat = meat;
        Age = 0;
        Random random = new Random();
        Sex = (AnimalGender)random.Next(0, 2);
    }
    public Pig(int age, int meat) : base(age)
    {
        Meat = meat;
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

    public int GiveMeat()
    {
        Age = null;
        Sex = null;
        Satiety = null;
        return Meat;
    }

    public override Animal DoSex(Animal pig)
    {
        if (pig.Sex != Sex)
        {
            return new Pig(meat: 10);
        }
        else
        {
            return null;
        }
    }
}



