using System;

class Program
{
    static void Main()
    {
        int startInterval, endInterval;

        try
        {
            Console.WriteLine("Введите начало интервала:");
            startInterval = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец интервала:");
            endInterval = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Совершенные числа в диапазоне от {startInterval} до {endInterval}:");
            FindPerfectNumbers(startInterval, endInterval);
        }
        catch (FormatException)
        {
            Console.WriteLine("Введите целое число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Введенное число слишком большое.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static void FindPerfectNumbers(int start, int end)
    {
        for (int num = start; num <= end; num++)
        {
            if (IsPerfectNumber(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    static bool IsPerfectNumber(int num)
    {
        int sumOfDivisors = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sumOfDivisors += i;
            }
        }

        return sumOfDivisors == num;
    }
}
