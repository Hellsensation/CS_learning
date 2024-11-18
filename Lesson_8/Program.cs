namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();

            int day = 0;
            Farm farm = new Farm();

            Cow cow1 = new Cow(age: 5, AnimalGender.female, consoleLogger);
            Cow cow2 = new Cow(age: 7, AnimalGender.male, consoleLogger);

            Chicken chicken1 = new Chicken(age: 1, AnimalGender.female, fileLogger);
            Chicken chicken2 = new Chicken(age: 2, AnimalGender.male, fileLogger);

            Pig pig1 = new Pig(age: 1, meat: 25, AnimalGender.female, fileLogger);
            Pig pig2 = new Pig(age: 2, meat: 35, AnimalGender.male, fileLogger);


            Console.WriteLine("Добавляем животных на ферму");
            farm.AddAnimal(cow1);
            farm.AddAnimal(cow2);

            farm.AddAnimal(chicken1);
            farm.AddAnimal(chicken2);

            farm.AddAnimal(pig1);
            farm.AddAnimal(pig2);

            

            Console.WriteLine($"На данный момент на ферме\n" +
                $"Молока: {farm.GetInfoAboutMilk()}\n" +
                $"Яиц: {farm.GetInfoAboutEggs()}\n" +
                $"Мяса: {farm.GetInfoAboutMeat()}");


            while (day < 30)
            {
                Console.WriteLine("Кормим животных");
                farm.FeedAnimal();
                pig1.DoSex(pig2);
                day++;  
            }





        }

    }
}
