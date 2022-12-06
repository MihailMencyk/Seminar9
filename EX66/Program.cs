// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (M < N)
{
    for (int i = 0; i <= N-M; i++)
    {
        sum = sum + (N-i);
    }
    System.Console.WriteLine($"Сумма элементов от M до N: {sum}");
}
else System.Console.WriteLine("Ошибка! (значение N  должно быть больше значения M)");