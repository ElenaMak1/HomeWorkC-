// See https://aka.ms/new-console-template for more information
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}

int SumOddPositionInArray(int[] array)
{
    int summa = 0;
    int i = 1; 
    while(i < array.Length)
    {
        summa = summa + array[i];
            i = i +2;
    }
    return summa;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях {SumOddPositionInArray(array)}");