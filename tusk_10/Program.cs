Console.Clear();

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int GetMaxDigit(int number)
{
    int max = number % 10;
    int digit2 = number / 10;

    if (max < digit2)
    {
        max = digit2;
    }
    return max;
}

int randomNumber = GetNumberFromRange(10, 99);
int maxDigit = GetMaxDigit(randomNumber);

Console.WriteLine($"Для числа {randomNumber} максимальной цифрой является {maxDigit}");