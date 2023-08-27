//Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*int CountNumbersPozitive(int size)
{
    int c = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input number {i + 1}: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) c += 1;  
    }
    return c;
}

Console.Write("Enter the count of numbers to check: ");
Console.Write(CountNumbersPozitive(Convert.ToInt32(Console.ReadLine())));
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/* void PointIntersection(float k1, float k2, float b1, float b2)
{
    if (k1 == k2) Console.WriteLine("Линии паралельны!");
    if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают!");
    else
    {
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    Console.WriteLine($"({x}; {y})");
    }
}


Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

PointIntersection(k1, k2, b1, b2);
*/

























// int k1 = 5;
// int k2 = 9;
// int b1 = 2;
// int b2 = 4;

// void PointIntersection(int k1, int k2, int b1, int b2)
// {
//     if (k1 == k2) Console.WriteLine("Линии паралельны!");
//     if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают!");
//     else
//     {
//     double x = 0; //(b2 - b1) / (k1 - k2);
//     double a1 = k1 - k2;
//     double a2 = b2 - b1;
//     x = a2 / a1;
//     double y = k1 * x + b1;
//     Console.WriteLine($"({x}; {y})");
//     }
// }

// PointIntersection(k1, k2, b1, b2);


// Console.Write("Input a k1: ");
// int num = Convert.ToInt32(Console.ReadLine());


















