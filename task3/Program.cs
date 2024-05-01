//  3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 99);
    PrintArray(array);
    RecursionPrintArray(array);
    
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; ++i)
    {
        tempArray[i] = rand.Next(minRange, maxRange + 1);
    }
    return tempArray;
}

void RecursionPrintArray(int[] arrayForPrint)
{
    if (arrayForPrint.Length < 1) return;
    RecursionPrintArray(arrayForPrint[1..]);
    System.Console.Write(arrayForPrint[0] + " ");
    
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


Main();
