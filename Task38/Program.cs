// See https://aka.ms/new-console-template for more information
// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,01 7,23 22,79 2,38 78,45] -> 76,07

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (50 + 50) - 50, 2); // [-50, 50]
}


double DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
        max = array[i];
        if (min > array[i])
        min = array[i];
        i = i + 1;
    }
    return max - min;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
DifferenceMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива будет:[{DifferenceMinMax(array)}]");