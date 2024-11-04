namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Cow cow1 = new Cow(age: 22, milk: 21, AnimalGender.female);
            Cow cow2 = new Cow(age: 22, milk: 21, AnimalGender.male);

            Cow re = cow1.DoSex(cow2);


        }
    }
}
