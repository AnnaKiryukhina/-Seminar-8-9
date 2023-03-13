// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите значение М");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber (int n, int m)
{
    
    if ( n==m) return m;
    return m + SumNumber(n, m-1);

}

System.Console.WriteLine(SumNumber(m,n));