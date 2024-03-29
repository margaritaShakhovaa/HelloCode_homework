﻿// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.Clear();

void FillArray(int[,] array) // заполняем двумерный массив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число от 1 до 9: ");
int value = int.Parse(Console.ReadLine()); // переменная int, вееденная пользователем
Console.WriteLine();

int FindArray(int[,] array) // ищем индексы числа, введенного пользователем
{
    int row = 0;
    int column = 0;
    int count = 0;  // добавили счетчик для ситуации, в которой не выполняется нужное условие (элемент отсутствует в массиве)
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == value)
            {
                row = i;
                column = j;
                Console.Write($"Число {value} стоит на позиции [{row},{column}]");
                Console.WriteLine();
                count++; 
            }
        }
    }
    if (count == 0) // условие, которое выполняет команду вывода сообщения об отсутствии элемента в массиве, 
                    // счетчик нужен для того, чтобы итерация не зацикливалась
        {
            Console.Write($"Число {value} отсутствует в массиве.");
        } 
    return 0;
}

int[,] array = new int[3,3];
FillArray(array);
Console.WriteLine();
FindArray(array);