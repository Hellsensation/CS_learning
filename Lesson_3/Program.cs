using System.Threading.Channels;

namespace Lesson_3;

class Program
{
    
    
    static void Main(string[] args)
    {
        int arrLength = 1;
        int[] numbers = new int[arrLength];
        string number = "";
        int iterationCount = 0;
        
        while (number != "q")
        {
            try
            {
                Console.WriteLine("Enter number");
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
                Console.WriteLine("Введеный данные нверны. Введите число.");
            }
        }
        foreach (var VARIABLE in numbers)
        {
            Console.WriteLine(VARIABLE);
        }
        
        
        static int[] ResizeArr(int[] nums)
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
}


