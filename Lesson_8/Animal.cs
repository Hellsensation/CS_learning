namespace Lesson_8;

public class Animal
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

}

public class Cow : Animal
{
    int Milk;
    public Cow(int milk)
    {
        Milk = milk;    
    }
}






