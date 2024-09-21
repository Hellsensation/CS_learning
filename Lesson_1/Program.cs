namespace Lesson_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добрый день, что будем делать?\n1 - Вывести ФИО\n2 - Проверить калькулятор");
        int choise = int.Parse(Console.ReadLine());
        if (choise == 1)
        {
            Names nm = new Names();
            nm.printName();
        }
        else if (choise == 2)
        {
            Calculator clc = new Calculator();
            clc.calculate();
        }
        else
        {
            Console.WriteLine("Нет такого варианта");
        }
    }
}