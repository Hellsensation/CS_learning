namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Print("asdfdf", ConsoleColor.DarkGreen);


        }
        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }


    }
}
