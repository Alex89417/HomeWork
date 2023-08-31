//Task 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2dRandomArray(int rows, int columns)
{
    int[,] array2d = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i, j] = new Random().Next(1, 10);
            
return array2d;        
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
    Console.WriteLine();
    }
}

int[,] WillSoftArrayDescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] > array[i, j - 1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j - 1];
                array[i, j - 1] = temp;
                for (int k = 0; k < j; j--)
                {
                    if (array[i, j] > array[i, j - 1])
                    {
                    temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;
                    }
                }
            } 
        }
    }
    return array;
}












Console.Write("Input a row array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column array: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArr = Create2dRandomArray(rows, columns);
Write2dArray(myArr);
Console.WriteLine();
Write2dArray(WillSoftArrayDescendingOrder(myArr));














//Task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





























//Task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц:
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18





























//Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента:
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



























//Task 62. Напишите программу, которая заполнит спирально массив 4 на 4
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




































































