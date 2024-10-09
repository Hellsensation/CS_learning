namespace Lesson_5;

class Program
{
    static void Main(string[] args)
    {

        CreateField();
        Shag();
        
    }


    static void CreateField()
    {
        Console.Write(" ABC");
        Console.SetCursorPosition(0, 1);
        Console.Write("1");
        Console.SetCursorPosition(0, 2);
        Console.Write("2");
        Console.SetCursorPosition(0, 3);
        Console.Write("3");

    }

    static void Shag()
    {
        Console.WriteLine("Enter ABC");
        string symbol = Console.ReadLine();

        if (symbol == "A")
        {
            Console.WriteLine("Enter 123");
            int num = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(1, num);
            Console.Write("X");
        }
        else if (symbol == "B")
        {
            Console.WriteLine("Enter 123");
            int num = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(2, num);
            Console.Write("X");
        }
        else if (symbol == "C")
        {

            Console.WriteLine("Enter 123");
            int num = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(3, num);
            Console.Write("X");

        }
    }

    enum FiledCeils
    {
        A = 1,
        B = 2,
        C = 3,
    }
}
