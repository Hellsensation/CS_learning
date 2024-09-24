using System.Threading.Channels;

namespace Lesson_2;

public class Users
{
    private string[][] users = new string[3][];
    string[] arr = new string[4];
    
    public void UserAdd()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nВведите ФИО человека {i+1} через пробел");
            string username = Console.ReadLine().ToLower();
            
            arr = username.Split(' ').ToArray();
            users[i] = arr;
        }
        PrintUsername();
    }

    private void PrintUsername()
    {
        Console.WriteLine("Введите ИМЯ человека, котрого хотите получить ФИО");
        string? firstName = Console.ReadLine().ToLower();
        
        foreach (var user in users)
        {

            foreach (var elem in user)
            {
                 if (firstName == user[1])
                 {
                     Console.Write($"{elem} ");
                 }
                 else
                 {
                     Console.WriteLine("Такого пользователя нет в базе данных");
                     break;
                 }
            }
        }
    }
}