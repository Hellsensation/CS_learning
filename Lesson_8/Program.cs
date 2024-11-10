namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Cow cow1 = new Cow(age: 22, milk: 21, AnimalGender.female);
            Cow cow2 = new Cow(age: 22, milk: 21, AnimalGender.male);

            Animal? newCow = cow1.DoSex(cow2);
            Farm farm = new Farm();
            farm.GiveFood(56);
            



        }

        private static void FoodChanged(object sender, EventArgs e) 
        {
            AnimalActionsArgs
        }
    }
}
