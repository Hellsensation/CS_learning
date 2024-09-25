using System.Threading.Channels;

namespace Lesson_2;

public class Users
{
    public void UserAdd()
    {
        string[][] users = new string[3][];
        users[0] = new string[3];
        users[1] = new string[3];
        users[2] = new string[3];

        Console.WriteLine("\nВведите ФИО первого пользоватля");
        Console.Write("Имя: ");
        users[0][0] = Console.ReadLine();
        Console.Write("Фамилия: ");
        users[0][1] = Console.ReadLine();
        Console.Write("Отчество: ");
        users[0][2] = Console.ReadLine();
        
        Console.WriteLine("Введите ФИО второго пользоватля");
        Console.Write("Имя: ");
        users[1][0] = Console.ReadLine();
        Console.Write("Фамилия: ");
        users[1][1] = Console.ReadLine();
        Console.Write("Отчество: ");
        users[1][2] = Console.ReadLine();
        
        Console.WriteLine("Введите ФИО третьего пользоватля");
        Console.Write("Имя: ");
        users[2][0] = Console.ReadLine();
        Console.Write("Фамилия: ");
        users[2][1] = Console.ReadLine();
        Console.Write("Отчество: ");
        users[2][2] = Console.ReadLine();

        Console.WriteLine("Данные какого пользоватя вывести? (1, 2, 3)");
        int userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"{users[userNumber-1][0]} {users[userNumber-1][1]} {users[userNumber-1][2]}");
    }
}