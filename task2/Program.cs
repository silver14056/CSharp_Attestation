// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

void Main()
{
    int numberN = ReadInt("Введите число N: ");
    int numberM = ReadInt("Введите число M: ");
    Console.WriteLine(FunctionA(numberN, numberM));
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionA(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FunctionA(n - 1, 1);
    }
    else
    {
        return FunctionA(n - 1, FunctionA(n, m - 1));
    }
}

Main();