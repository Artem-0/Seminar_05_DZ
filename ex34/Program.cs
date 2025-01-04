// Здалача 34. Задайте массив, заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return newArray;
}

void PrintArray2(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
            count++;
    }
    return count;
}

// -------------------------------------------------------------------------

int[] array = GenerateArray(4, 100, 999);
PrintArray2(array);
System.Console.WriteLine("Количество чётных чисел в массиве: " + CountEvenNumbers(array));