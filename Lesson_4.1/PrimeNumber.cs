using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1;



public static class PrimeNumber
{
    public static void FindNumber()
    {
        while (true)
        {
            Console.Write("Введите значение N: ");

            string? userInput = Console.ReadLine();
            bool userNumber = int.TryParse(userInput, out var number);

            if (userNumber)
            {
                int primeNumCount = 0;
                int startNum = 2;

                while (primeNumCount < number)
                {
                    if (IsPrime(startNum))
                    {
                        primeNumCount++;
                    }
                    if (primeNumCount < number)
                    {
                        startNum++;
                    }
                }

                Console.WriteLine($"N-ое простое число: {startNum}");
            }
            else
            {
                Console.WriteLine("Введите число, а не строку.");
            }

        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
