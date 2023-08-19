/* Task 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве:

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int PositiveNumberCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}


Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(size);
WriteArray(MyArray);

Console.Write($" --> {PositiveNumberCounter(MyArray)}");
*/


/* Task 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях:

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(1, 1000);
         
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumElemente(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
        
    return sum;    
}

Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] MyArray = CreateRandomArray(size);
WriteArray(MyArray);
Console.WriteLine($"Sum of odd element indexes = {SumElemente(MyArray)}");
*/


/* Task 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива:

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the real number of the array under the index {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

double RaznicaMinMax(double[] array)
{
    double minV = array[0];
    double maxV = array[0];
    double dif = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minV > array[i]) minV = array[i];
        if (maxV < array[i]) maxV = array[i];
    }
    Console.WriteLine($"минимальное значение = {minV}");
    Console.WriteLine($"минимальное значение = {maxV}");
    return dif = maxV - minV;
}


Console.Write("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] MyArr = CreateArray(size);
WriteArray(MyArr);
Console.WriteLine($"Разница между мин. и макс. значением = {RaznicaMinMax(MyArr)}");
*/


