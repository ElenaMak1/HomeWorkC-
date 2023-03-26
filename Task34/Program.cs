// See https://aka.ms/new-console-template for more information
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999); // [-9; 9]
}

int PositiveInArray(int[] array)
{
    int kol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)    // f (numbers[z] % 2 == 0)
            kol = kol + 1;
    }
    return kol;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел {PositiveInArray(array)}");
