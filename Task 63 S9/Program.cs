// Задача 63: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" N = 6 -> "1, 2, 3, 4, 5, 6"

//метод ввода числа
int ReadInt (string prompt)
{
    Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

// метод подсчета всех натуральных чисел в промежутке от 1 до N
void WriteNumber (int num)
{
    if (num==0) return;
    WriteNumber (num-1); // если необходимо вывод от N До 1 то 16 и 17 меняются местами
    Console.Write (num +" "); // если N=0 тогда возвращает числа от N до 0
  
}

// метод ввывода результата

    WriteNumber(ReadInt("Введите число"));
