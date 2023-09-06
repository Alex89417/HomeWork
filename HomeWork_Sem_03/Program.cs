// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом:
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/* 
bool Palidrom(string numbers)
{
    int i = 0;
    int len = numbers.Length;
    while (i < len/2) 
    {
        if (numbers[i] != numbers [len - i -1]) return false;
    i++;
    }
return true;
}

Console.WriteLine("Input a number: ");
string number = Console.ReadLine();

bool res = Palidrom(number);

if(res == true) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/



// Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/* void Quadrant(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int numX = (x1 - x2) * (x1 - x2);
    int numY = (y1 - y2) * (y1 - y2);
    int numZ = (z1 - z2) * (z1 - z2);
    Console.WriteLine(Math.Round(Math.Sqrt(numX + numY + numZ), 2));
}

Console.Write("Input a X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Quadrant(x1, y1, z1, x2, y2, z2);
*/



// Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/* void Cube(int number)
{
int current = 1;
if (number <= 0) Console.Write("Uncorrect data!");
while (current <= number)
    {
    Console.WriteLine($"{current} - {Math.Pow(current, 3)}; "); current++; 
    } 
}     

Console.Write("Enter a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/




