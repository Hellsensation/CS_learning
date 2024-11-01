namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Animal anuimal = new Animal(age:321, AnimalGender.female);

            Cow cow = new Cow(age:22, milk: 21);

        }
    }
}
