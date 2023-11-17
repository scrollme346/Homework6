using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое целое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int num2 = int.Parse(Console.ReadLine());

            int result = SumInRange(num1, num2);
            Console.WriteLine($"Сумма чисел в диапазоне: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Нужно ввести цифру");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Результат операции слишком большой для данного типа данных");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
        }
    }

    static int SumInRange(int num1, int num2)
    {
        if (num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        int sum = 0;

        for (int i = num1; i <= num2; i++)
        {
            sum += i;
        }

        return sum;
    }
}
