// Задача 1: Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ 
// натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5, M = 9 -> "6, 8"
// N = 2, M = 10 -> "2, 4, 6, 8, 10"


Console.Write("Введите число => ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }
    if (n % 2 == 0)
    Console.Write(n);
    PrintNumbers(n - 1);
   
}
PrintNumbers (n);

