using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the base: ");//просим пользователя ввести основание степени
            double baseNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the exponent: ");//просим пользователя ввести показатель степени
            int exponent = Convert.ToInt32(Console.ReadLine());

            double result = PowerToExponent(baseNumber, exponent);//вызываем функцию и выводим результат
            Console.WriteLine($"{baseNumber}^{exponent} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Не дели на ноль");
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

    static double PowerToExponent(double baseNumber, int exponent)
    {
        double result = Math.Pow(baseNumber, exponent);//используем встроенную функцию Math.Pow для возведения в степень
        return result;
    }
}
