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

Console.WriteLine("");
Console.WriteLine("Следующая задача");
Console.WriteLine("");

// Решение задачи № 2

void Main2()
{
    int[] array = GenerateArray(10, 100, 1000);
    PrintArray(array);
    Console.Write(EvenCountNumbers(array));
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(minRange, maxRange);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine(string.Join(", ", arrayForPrint));
}

int EvenCountNumbers(int[] anyArray)
{
    int count = 0;
    foreach (int num in anyArray)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


Main2();

Console.WriteLine("");
Console.WriteLine("Следующая задача");
Console.WriteLine("");

// Решение задачи № 3

void Main3()
{
    int[] array = GenerateArray(10, 0, 50);
    PrintArray(array);
    ReversArray(array);
}

void ReversArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    Console.WriteLine("Перевернутый массив:");
    foreach (int number in arr)
    {
        Console.Write(number + ", ");
    }
}

Main3();