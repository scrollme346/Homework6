using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите шестизначное число:");
        try
        {           
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsSixDigitNumber(number))
            {
                //Функция для проверки
                bool isHappy = IsHappyNumber(number);

                if (isHappy)
                {
                    Console.WriteLine($"Число {number} - счастливое!");
                }
                else
                {
                    Console.WriteLine($"Число {number} - не счастливое.");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное шестизначное число.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Пожалуйста, введите корректное число.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static bool IsSixDigitNumber(int num)
    {
        // Проверяем, является ли число шестизначным
        return num >= 100000 && num <= 999999;
    }

    static bool IsHappyNumber(int num)
    {
        // Разбиваем число на цифры
        int num1 = num / 100000;
        int num2 = num / 10000 % 10;
        int num3 = num / 1000 % 10;
        int num4 = num / 100 % 10;
        int num5 = num / 10 % 10;
        int num6 = num % 10;

        // Проверяем условие счастливого числа
        return (num1 + num2 + num3) == (num4 + num5 + num6);
    }
}
