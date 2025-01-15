namespace Lesson_8;


public enum AnimalGender
{
    male = 0,
    female = 1
}

public class ConsoleLogger : ILogger
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}

public class FileLogger : ILogger
{

    public void Print(string text)
    {
        File.AppendAllText("log.txt", text);
    }
}

