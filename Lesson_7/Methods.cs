namespace Lesson_7;

using static Methods;

public static class Methods
{
    public static void Print(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}
