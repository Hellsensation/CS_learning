namespace Lesson_1;

class Program
{
    static void Main(string[] args)
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