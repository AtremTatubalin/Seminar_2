// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int Size(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num /10;
        count++;
    }
    return count;
}

int ThirdDigit(int num, int count)
{
    int d1 = 10;
    while(count >= 5)
    {
        d1 = d1 * 10;
        count = count - 1;
    }
    int digit = (num / d1) % 10;
    return digit;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int numberLenght = Size(number);

if (numberLenght == 3)
{
    int a3 = number % 10;
    Console.WriteLine($"Третья цифра {a3}");
}
else
{
    if (numberLenght <= 2)
{
    Console.WriteLine("Третьей цыфры нет.");
}
else
{
int ThirdNum = ThirdDigit(number, numberLenght);
Console.WriteLine($"Третья цифра {ThirdNum}");
}if (numberLenght <= 2)
{
    Console.WriteLine("Третьей цыфры нет.");
}
else
{
int ThirdNum = ThirdDigit(number, numberLenght);
Console.WriteLine($"Третья цифра {ThirdNum}");
}
}