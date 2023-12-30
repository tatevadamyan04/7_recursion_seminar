//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("Original Array:");
PrintArray(array);

Console.WriteLine("\nArray in Reverse Order:");
PrintArrayReverse(array, array.Length - 1);

static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintArrayReverse(array, index - 1);
    }
}

static void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
