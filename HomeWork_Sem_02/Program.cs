/* Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа:

int CutNumber(int num)
{
    return num / 10 % 10;
}

Console.Write("Input a three digit number: ");
int result = CutNumber(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine(result);
*/

/* Task 13. Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет):

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > -100 && num < 100) Console.WriteLine("Третьей цифры нет!");
if (num < -99 && num > -1000 || num > 99 && num < 1000) 
{
    int res = num % 10;
    Console.WriteLine(res);
}

if (num < -999 && num > -10000 || num > 999 && num < 10000) 
{
    int number = num % 100;
    int res = number / 10;
    Console.WriteLine(res);
}

if (num < -9999 && num > -100000 || num > 9999 && num < 100000) 
{
    int number = num % 1000;
    int res = number / 100;
    Console.WriteLine(res);
} */

/* Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным:

Console.Write("Enter the day of the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Рабочий");
*/


//-----------------------------------------------------------------------------------------------------------------

/* //*Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа:

Console.Write("Input a number: ");
// Console.Write(Convert.ToInt32(Console.ReadLine()) / 10 % 10); 
Console.WriteLine(Console.ReadLine()![1]); */

/* //Task 13. Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет):

Console.Write("Input a number: ");
string n = Console.ReadLine()!;
if (n.Length <= 2) Console.WriteLine("Значение меньше 100!");
else Console.WriteLine(n[2]); */

/* //Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным:

Repeat:
Console.Write("Input a day of the week: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7) goto Repeat;
if (n < 6) Console.WriteLine("Этот день не является выходным!");
else Console.WriteLine("Ура выходной!!!"); */






