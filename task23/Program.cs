// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i;
for (i = 1; i <= n; i++)
{
    //int res = i * i * i;
    double res = Math.Pow(i, 3);
    Console.Write(res + ", ");
}
