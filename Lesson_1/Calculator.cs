using System.Threading.Channels;

namespace Lesson_1;

public class Calculator
{
    public void calculate()
    {
        Console.WriteLine("Введите первое число");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите маетматическую операцию");
        char action = char.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите второе число");
        double num2 = double.Parse(Console.ReadLine());

        if (action == '+')
        {
            double result = num1 + num2;
            Console.WriteLine($@"Результат = {result}");
        }
        else if (action == '-')
        {
            double result = num1 - num2;
            Console.WriteLine($@"Результат = {result}");
        }
        else if (action == '*')
        {
            double result = num1 * num2;
            Console.WriteLine($@"Результат = {result}");
        }
        else if (action == '/')
        {
            double result = num1 / num2;
            Console.WriteLine($@"Результат = {result}");
        }
    }
}