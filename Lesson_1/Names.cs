namespace Lesson_1;

public class Names
{
    public void printName()
    {
        Console.WriteLine("Введите имя:");
        string? name = Console.ReadLine();
        
        Console.WriteLine("Введите фамилию:");
        string? surename = Console.ReadLine();
        
        Console.WriteLine("Введите отчество:");
        string? patronymic = Console.ReadLine();
        
        Console.WriteLine($@"{name} {surename} {patronymic}");
    }

}