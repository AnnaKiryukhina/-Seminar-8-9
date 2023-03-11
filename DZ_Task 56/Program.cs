// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


System.Console.WriteLine("Введите количество строк в матрице");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());


int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}
// задаем метод вывода матрицы на печать
void PrintMatrix(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] +" ");
        }
        System.Console.WriteLine();
    }
}

int FindMinSum(int[,] matrix)
{
    int index =0;
    int minsum = 0;
    {
        for (int i =0; i<matrix.GetLength(0); i++)
        {
            int sum =0;
            for (int j =0; j<matrix.GetLength(0); j++)
            {
                if (i==0)
                    minsum = minsum + matrix[i,j];
                else
                    sum = sum + matrix[i,j];
            }
            if (i==0)
            {
                index = i;
            }
            else if (minsum >= sum)
            {
                minsum =sum;
                index = i;
            }
        }
    }
    return index;

}
var myMatrix = GenerateMatrix(m,n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int minIndex = FindMinSum(myMatrix);
System.Console.WriteLine($"Минимальная сумма находиться в строке{minIndex}");
