// See https://aka.ms/new-console-template for more information
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Clear();
int Prompt (string message)
{

    Console.Write("Введите число: ");
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}   
 
bool IsWeekend(int weekDay)
{
    if (weekDay < 5)
    {
       return true;
    }
    return false;
}   

bool ValidateWeekday(int number)

{
    if (number > 0 && number <= 7)
    {
       return true;
    }
    Console.WriteLine("Это не дент недели");
    return false;
}

int weekDay = Prompt("Введите день недели > ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец - то выходной");
    }
   else
   {
       Console.WriteLine("Рабочий день!");
   }
}
