// Задача 38. Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива.


void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(" ", arrayForPrint) + "]");
}

double FindMax(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double difference = FindMax(array) - FindMin(array);
    return difference;
}

// -------------------------------------------------------------------------

double[] array = {2.33, 3.56, 100.1, 4.2, 74, 3.4};
PrintArray(array);
System.Console.WriteLine(CalcDifferenceBetweenMaxMin(array));
