
/* Task 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B:

void numVDegree(int num, int degree)
{
    int res = num;
    for(int count = 1; count < degree; count++)
        res *= num;
   
    Console.WriteLine($"{num}, {degree} -> {res}");
}

Repeat:
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree: ");
int deg = Convert.ToInt32(Console.ReadLine());
if (num <= 0 || deg <= 0) 
{
    Console.Write("Uncorrect data! --> ");
    goto Repeat;
}

else numVDegree(num, deg);
*/



/* Task 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе:

void SumInNumbers(int number)
{
    int sum = 0;
    int num = number;
    while(num >= 10)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    sum += num;
    Console.WriteLine($"{number} -> {sum}");
}

Repeat:
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) 
{
    Console.Write("Uncorrect data! --> ");
    goto Repeat;
}

else SumInNumbers(num);
*/



/* Task 29. Напишите программу, которая задаёт массив из m элементов и выводит их на экран:

int[] CreateArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i} element array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}   

void WriteArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i] + " ");
        
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
WriteArray(myArray);
*/