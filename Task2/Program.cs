/*
Задача 2: 
    Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n.
*/

int AckFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckFunc(m - 1, 1);
    else
        return AckFunc(m - 1, AckFunc(m, n - 1));
}

Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());

int result = AckFunc(userM, userN);
Console.WriteLine($"Значение функции Аккермана для M = {userM} и N = {userN} равно {result}");
