using System.Threading.Channels;

namespace Lesson_3;

class Program
{
    static int arrLength = 1;
    static int[] numbers = new int[arrLength];
    static int iterationCount = 0;

    static void Main(string[] args)
    {
        Menu();
    }

    /// <summary>
    /// Меню программы.
    /// </summary>
    static void Menu()
    {
        Console.WriteLine("1 - Ввести числа\n2 - Очистить массив\n3 - Печать чисел из массива и завершение программы.");
        int userChoise = int.Parse(Console.ReadLine());
        
        switch (userChoise)
        {
            case 1:
                InputNumbers();
                break;
            case 2:
                ClearArray();
                break;
            case 3:
                PrintNumbers();
                break;
            default:
                Console.WriteLine("Ошибка");
                Menu();
                break;
        }
    }

    /// <summary>
    /// Очистка массива и установка размера в 1 место.
    /// </summary>
    static void ClearArray()
    {
        Console.WriteLine("Очистка массива.");
        numbers = new int [1];
        iterationCount = 0;
        Menu();
    }

    /// <summary>
    /// Печать чисел находящихся в массиве.
    /// </summary>
    static void PrintNumbers()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Число номер {i+1} = {numbers[i]} ");
        }
    }

    /// <summary>
    /// Добавление числа в массив.
    /// </summary>
    static void InputNumbers()
    {
        string number = "";
        while (number != "q")
        {
            try
            {
                Console.WriteLine("Введите число:");
                number = Console.ReadLine();
                numbers[iterationCount] = int.Parse(number);
                iterationCount++;
            }
            catch (IndexOutOfRangeException)
            {
                numbers = ResizeArr(numbers);
                numbers[iterationCount] = int.Parse(number);
                iterationCount++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введеные данные неверны. Введите число.");
            }
        }
        Menu();
    }
    
    /// <summary>
    /// Метод расширяющий массив на одно место.
    /// </summary>
    /// <param name="nums"></param>
    private static int[] ResizeArr(int[] nums)
    {
        int newArrLength = nums.Length + 1;
        int[] newArr = new int[newArrLength];
        for (int i = 0; i < nums.Length; i++)
        {
            newArr[i] = nums[i];
        }
        return newArr;
    }
}


