// See https://aka.ms/new-console-template for more information
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

// if (n % 2 > 0)
   // Console.WriteLine("нет");
