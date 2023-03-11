// See https://aka.ms/new-console-template for more information

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int o = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Max(n, Math.Max(m, o)));
