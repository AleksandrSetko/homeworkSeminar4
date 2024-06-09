// Решение Задачи № 1

void Main()
{
    while (true)
    {
        Console.Write("Введите целое число (или 'q' для выхода): ");
        string input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            break;
        }

        if (int.TryParse(input, out int num))
        {
            if (GetSumOfDigits(num) % 2 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {num} четная, программа завершается.");
                break;
            }
            else
            {
                Console.WriteLine($"Вы ввели число: {num}");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод, попробуйте снова.");
        }
    }
}

int GetSumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Main();
