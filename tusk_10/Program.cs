// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int ThirdDigit(int number)
{
    int digit3 = (number / 10) % 10;
    return digit3;
}

Console.WriteLine("Введите трёхзначное число.");

int num = int.Parse(Console.ReadLine());
int digit = ThirdDigit(num);

Console.WriteLine($"Вторая цифра числа {num} это {digit}");