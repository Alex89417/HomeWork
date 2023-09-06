/* // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Numbers (int n)
{
    if (n >= 1) return $"{n} " + Numbers (n - 1 );
    else return String.Empty;
}

Console.Write("Input the number: ");
Console.Write(Numbers (Convert.ToInt32(Console.ReadLine()))); */



/* // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers (int m, int n)
{
    if (m > n) return 0;
    else return m + SumNumbers(m + 1, n);
}

Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers (m, n)); */



/* // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akermana(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
        return Akermana(m - 1, 1);
    else
        return Akermana(m - 1, Akermana(m, n - 1));
}


Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akermana(m, n)); */