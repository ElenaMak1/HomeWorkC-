// See https://aka.ms/new-console-template for more information

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int n1 = n / 10;
Console.WriteLine(n1 % 10);




