namespace Lesson_2;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("1 - Проверить первое задание\n2 - Проверить второе задение");
        char choise = Console.ReadKey().KeyChar;
        if (choise == '1')
        {
            UserNumbers numbers = new UserNumbers();
            numbers.EnteringNumbers();
        }
        else if(choise == '2')
        {
            Users users = new Users();
            users.UserAdd();
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}