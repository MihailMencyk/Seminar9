// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNum (int N)
{
    if (N > 0) return $"{N} " + PrintNum(N-1);
    else return String.Empty;
}
System.Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(PrintNum(N));