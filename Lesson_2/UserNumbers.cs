namespace Lesson_2;

public class UserNumbers
{
    private readonly int[] _numbers = new int[7];
    private float _averageArithmetic;
    public void EnteringNumbers()
    {
        Console.WriteLine("\nСейчас нужно будет ввести 7 чисел.");
        try
        {
            for (var i = 0; i < 7; i++)
            {
                var number = int.Parse(Console.ReadLine());
                _numbers[i] = number;
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        CalculateAverage();
    }

    private void CalculateAverage()
    {
        foreach (var num in _numbers)
        {
            _averageArithmetic += num;
        }

        _averageArithmetic = _averageArithmetic / _numbers.Length;
        Console.WriteLine($"Среднее арифметическое введенных чисел:{_averageArithmetic}");
    }
}