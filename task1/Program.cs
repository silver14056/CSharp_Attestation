// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int numberM = ReadInt("Введите число M: ");
    int numberN = ReadInt("Введите число N: ");
    PrintNumbers(numberM, numberN);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (N < M) return;
    PrintNumbers(M, N - 1);
    Console.Write(N + " ");
}

Main();