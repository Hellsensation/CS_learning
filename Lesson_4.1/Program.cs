namespace Lesson_4._1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Что будем делать?\n1 - Поск простого числа\n2 - Игра с курицей");
        string userChoose = Console.ReadLine();

        if (userChoose == "1")
        {
            PrimeNumber.FindNumber();
        }
        else if (userChoose == "2")
        {
            Chicken.Menu();
        }
        else
        {
            Console.WriteLine("Введите 1 или 2");
        }
    }
}