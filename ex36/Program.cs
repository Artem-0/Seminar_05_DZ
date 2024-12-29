// Задача 36. Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

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

int SumOfElementsOnUnevenPosition(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i +=2)
        sum += array[i];
    return sum;
}

// -------------------------------------------------------------------------

int[] array = GenerateArray(4, -100, 100);
PrintArray2(array);
System.Console.WriteLine("Сумма элементов, стоящих на нечётных поициях: " + SumOfElementsOnUnevenPosition(array));