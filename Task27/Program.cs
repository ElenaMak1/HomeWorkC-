// See https://aka.ms/new-console-template for more information

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}   

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;    
    }
    return result;
}

int number = Prompt("Введите число:");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");

