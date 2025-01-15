namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();

            int day = 0;
            Farm farm = new Farm(consoleLogger);

            Cow cow1 = new Cow(age: 5, AnimalGender.female, consoleLogger);
            Cow cow2 = new Cow(age: 7, AnimalGender.male, consoleLogger);

            Chicken chicken1 = new Chicken(age: 1, AnimalGender.female, fileLogger);
            Chicken chicken2 = new Chicken(age: 2, AnimalGender.male, fileLogger);

            Pig pig1 = new Pig(age: 1, meat: 25, AnimalGender.female, consoleLogger);
            Pig pig2 = new Pig(age: 2, meat: 35, AnimalGender.male, consoleLogger);

            consoleLogger.Print("Добавляем животных на ферму");
            farm.AddAnimal(cow1);
            farm.AddAnimal(cow2);

            farm.AddAnimal(chicken1);
            farm.AddAnimal(chicken2);

            farm.AddAnimal(pig1);
            farm.AddAnimal(pig2);

            cow1.PrintInfo();
            chicken1.PrintInfo();
            pig2.PrintInfo();
            
            farm.GetInfoAboutEatinFarm();


            while (day < 30)
            {
                farm.FeedAnimal();
                pig1.DoSex(pig2);
                day++;  
            }
        }
    }
}
