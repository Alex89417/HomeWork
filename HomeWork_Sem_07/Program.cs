//Task 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами:
/*
double[,] Random2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array2d = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array2d[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);

    return array2d;
}

void Write2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
    Console.WriteLine();
    }
}

 
Console.Write("Input a quantifi of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantifi of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] MyArray = Random2dArray(rows, columns, minValue, maxValue);
Write2dArray(MyArray);
*/


//Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет:
/* 
double[,] Random2dArray()
{
    double[,] array2d = new double[5, 5];

    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            array2d[i, j] = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);

    return array2d;
}

void WriteElement(double[,] array, int i, int j)
{
    Console.WriteLine($"[{array[i, j]}]");
}

void Write2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
    Console.WriteLine();
    }
}


Repeat:
Console.Write("Input a row array: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a column array: ");
int j = Convert.ToInt32(Console.ReadLine());
if (i > 4 || j > 4)
{
    Console.Write("Uncorrect data! --> ");
    goto Repeat;
}

Console.WriteLine();
double[,] MyArray = Random2dArray();
Write2dArray(MyArray);
Console.WriteLine();
WriteElement(MyArray, i, j);
*/


//Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце:

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

void asdas(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        
        Console.WriteLine($"Среднее арифметическое {j} столбца = {Math.Round(sum / array.GetLength(0), 2)}");
    }
}


Repeat:
Console.Write("Input a quantifi of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantifi of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows < 1 || columns < 1)
{
    Console.Write("Uncorrect data! --> ");
    goto Repeat;
}

int[,] MyArray = Create2dRandomArray(rows, columns);
Write2dArray(MyArray);
Console.WriteLine();
asdas(MyArray);


