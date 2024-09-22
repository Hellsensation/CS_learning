using System.Threading.Channels;

namespace Lesson_1;

public class Calculator
{
    public void calculate()
    {
        Console.WriteLine("Введите первое число");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите маетматическую операцию");
        char action = Console.ReadKey().KeyChar;
        
        Console.WriteLine("\nВведите второе число");
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

            if (num2 == 0)
            {
                Console.WriteLine("Ошибка. Делить на ноль нельзя.");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($@"Результат = {result}");
            }
            
        }
    }
}