/* //Task 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива:
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
        for (int j = 0; j < array.GetLength(1); j++)
        {       
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
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
*/



/* //Task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
            Console.Write(array[i, j] + " ");
            sum += array[i, j];
            }
        Console.Write($"  --> Сумма = {sum}");

    Console.WriteLine();
    }
}

void MinRowArray(int[,] array)
{
    int sumMin = 0;
    int row = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
            
        if (i == 0)
            sumMin = sum;

        if (sum < sumMin)
        {
            sumMin = sum;
            row = i;
        }    
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальнвая сумма в строке под номерам {row + 1}!");
}


Console.Write("Input a row array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] myArr = Create2dRandomArray(rows, columns);
Write2dArray(myArr);
MinRowArray(myArr);
*/



/* //Task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц:
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Create2dRandomArray(int rows, int columns)
{
    int[,] array2d = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i, j] = new Random().Next(0, 10);
            
return array2d;        
}

void WriteTwoMatrix(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
            Console.Write(array1[i, j] + " ");

        Console.Write("  |   ");

        for (int k = 0; k < array1.GetLength(1); k++)
        {
            Console.Write(array2[i, k] + " ");
        }
        
    Console.WriteLine();
    }
}

void MatrixProduct(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        if (i > 0) Console.Write("|  ");

        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int res = 0;

            for (int k = 0; k < array1.GetLength(1); k++)
            {
                res += (array1[j, k] * array2[k, i]);
            }

            Console.Write(res + "  ");  
        }
    }
}


Console.Write("Input a row array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column array: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArr1 = Create2dRandomArray(rows, columns);
int[,] myArr2 = Create2dRandomArray(rows, columns);

Console.WriteLine();
WriteTwoMatrix(myArr1, myArr2);

Console.WriteLine();
MatrixProduct(myArr1, myArr2);
*/



/* //Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента:
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3dRandomArray(int list, int rows, int columns)
{
    int[,,] array = new int[list, rows, columns];

    for (int k = 0; k < list; k++)
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                Repeat:
                int temp = new Random().Next(10, 100);
                for (int l = 0; l < list; l++)
                    for (int m = 0; m < rows; m++)
                        for (int n = 0; n < columns; n++)
                            if (array[l, m, n] == temp) goto Repeat;
                        
                array[k, i, j] = temp;
            }
    return array;        
}

void Write2dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.WriteLine();

            for (int j = 0; j < array.GetLength(2); j++)
                Console.Write($"   {array[k, i, j]} -> ({k},{i},{j})");
        }    
    Console.WriteLine();          
    }  
}


Console.Write("Input a list array: ");
int list = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a row array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Write2dArray(Create3dRandomArray(list, rows, columns));
*/



//Task 62. Напишите программу, которая заполнит спирально массив 4 на 4
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateEndFiilSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int num = 1;

    for (int j = 0; j <= 2; j++)
    {
        
    for (int i = 0 + j; i < columns - j; i++)
    {
        array[0 + j, i] = num;
        num++;
    }
    num--;

    for (int i = 0 + j; i < rows - j; i++)
    {
        array[i, columns - 1 - j] = num;
        num++;
    }
    num--;

    for (int i = columns - 1 - j; i >= 0 + j; i--)
    {
        array[rows - 1 - j, i] = num;
        num++;
    }
    num--;

    for (int i = rows - 1 - j; i > 0 + j; i--)
    {
        array[i, 0 + j] = num;
        num++;
    }
    

    }


    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

Console.Write("Input a row array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Write2dArray(CreateEndFiilSpiralArray(rows, columns));






























































