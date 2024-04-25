/*
Задача 3: 
    Задайте произвольный массив. Выведете его элементы, начиная с конца. 
    Использовать рекурсию, не использовать циклы.
*/

void PrintArray(int[] array, int i = 0)
{
    if (i == array.Length)
    {
        return;
    }

    PrintArray(array, i + 1);

    Console.Write($"{array[i]} "); // При возвращении из рекурсии будет выводиться на печать обратный порядок значений из массива
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 

PrintArray(array);

Console.WriteLine();
