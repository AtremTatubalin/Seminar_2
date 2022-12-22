//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();

int number = int.Parse(Console.ReadLine()!);


if (number < 8)
{
    if (number < 6)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("неверное число.");
}