namespace Lesson_4;

public static class PrimeNumber
{
    public static void FindNumber()
    {
        while (true)
        {
            Console.Write("Введите значение N: ");
            
            int userNumber = int.Parse(Console.ReadLine() );
        
            int primeNumCount = 0; 
            int startNum = 2;   

            while (primeNumCount < userNumber)
            {
                if (IsPrime(startNum))
                {
                    primeNumCount++;
                }
                if (primeNumCount < userNumber) 
                {
                    startNum++;
                }
            }
        
            Console.WriteLine($"N-ое простое число: {startNum}");
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
