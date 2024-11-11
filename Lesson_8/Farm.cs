using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8;

class Farm
{

    public List<Animal> animals = [];


    public void AddAnimal(Animal animal)
    {
        animal.AnimalBorn += Animal_AnimalBorn;
    }

    private void Animal_AnimalBorn(Animal newAnimal)
    {
        Console.WriteLine($"Родилось новое животное! Рода: {newAnimal.GetType().Name}, Пол: {newAnimal.Sex}");
    }


    public void FeedAnimal() 
    {
        foreach(var animal in animals)
        {
            animal.ToEat(20);
        }
    }



    public int GetInfoAboutMilk()
    {
        int milkCount = 0;
        foreach (Animal animal in animals)
        {
            if (animal is Cow cow)
            {
                milkCount += cow.Milk;
            }
        }
        return milkCount;
    }

    public int GetInfoAboutEggs()
    {
        int eggCount = 0;
        foreach (Animal animal in animals)
        {
            if (animal is Chicken chicken)
            {
                eggCount += chicken.Eggs;
            }
        }
        return eggCount;
    }


    public int GetInfoAboutMeat()
    {
        int meatCount = 0;
        foreach (Animal animal in animals)
        {
            if (animal is Pig pig)
            {
                meatCount += pig.Meat;
            }
        }
        return meatCount;
    }
}






