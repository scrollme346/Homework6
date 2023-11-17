using System;

class Program
{
    static void Main()
    {
        // Пример массива карт
        string[] cards = { "2 треф", "10 черви", "Король треф", "Дама бубен", "Туз крести" };

        // Просим пользователя ввести номер карты
        Console.WriteLine("Введите порядковый номер карты (от 1 до 5):");

        try
        {         
            int cardIndex = Convert.ToInt32(Console.ReadLine());

            // Вызываем функцию с введенным пользователем индексом карты
            DisplayCard(cards, cardIndex - 1); // Вычитаем 1, так как пользователь вводит от 1 до 5
        }
        catch (FormatException)
        {
            Console.WriteLine("Введите корректный номер карты.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static void DisplayCard(string[] cardArray, int cardIndex)
    {
        try
        {
            if (cardIndex >= 0 && cardIndex < cardArray.Length)// Проверяем, что индекс находится в пределах массива
            {
                Console.WriteLine($"Выбрана карта под номером {cardIndex + 1}: {cardArray[cardIndex]}");
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректный номер карты.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
