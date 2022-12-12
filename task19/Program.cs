// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);

int a1 = (a / 10000) % 10;
//Console.WriteLine(a1);

int a2 = (a / 1000) % 10;
//Console.WriteLine(a2);

int a4 = (a / 10) % 10;
//Console.WriteLine(a4);

int a5 = a % 10;
//Console.WriteLine(a5);

if (a1 == a5)
{
    if (a2 == a4)
    {
        Console.WriteLine("Да, является палиндромом");
        return;
    }
}
Console.WriteLine("Нет, не является палиндромом");