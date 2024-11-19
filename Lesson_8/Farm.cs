

namespace Lesson_8;

class Farm
{

    public List<Animal> animals = [];
    public readonly ILogger _logger;
    private int milkCount = 0;
    private int eggCount = 0;
    private int meatCount = 0;

    public Farm(ILogger logger)
    {
        _logger = logger;
    }

    public void AddAnimal(Animal animal)
    {
        animal.AnimalBorn += Animal_AnimalBorn;
    }

    private void Animal_AnimalBorn(Animal newAnimal)
    {
        _logger.Print($"Родилось новое животное! Рода: {newAnimal.GetType().Name}, Пол: {newAnimal.Sex}");
    }



    public void FeedAnimal() 
    {
        foreach(var animal in animals)
        {
            animal.ToEat(20);
        }
        _logger.Print("Кормим животных");
    }



    public void GetInfoAboutMilk()
    {
        int milkCount = 0;
        foreach (Animal animal in animals)
        {
            if (animal is Cow cow)
            {
                milkCount += cow.Milk;
            }
        }
    }

    public void GetInfoAboutEggs()
    {
        int eggCount = 0;
        foreach (Animal animal in animals)
        {
            if (animal is Chicken chicken)
            {
                eggCount += chicken.Eggs;
            }
        }
    }

    public void GetInfoAboutMeat()
    {
        int meatCount = 0;
        foreach (Animal animal in animals)
        {
            if (animal is Pig pig)
            {
                meatCount += pig.Meat;
            }
        }
    }

    public void GetInfoAboutEatinFarm()
    {
        GetInfoAboutMilk();
        GetInfoAboutEggs();
        GetInfoAboutMeat();
        _logger.Print($"На данный момент на ферме\n" +
                $"Молока: {milkCount}\n" +
                $"Яиц: {eggCount}\n" +
                $"Мяса: {milkCount}");
    }


}






