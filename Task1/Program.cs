/*
Задача 1: 
    Задайте значения M и N. Напишите программу, которая выведет все натуральные 
    числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/

void PrintNaturalNumbers(int startM, int endN)
{
    if (startM > endN)
        return;

    Console.Write($"{startM} ");
    PrintNaturalNumbers(startM + 1, endN);
}

Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(userM, userN);
Console.WriteLine();
