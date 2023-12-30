//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Enter the value of M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value of N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.Write("Number M is bigger than number N, so I will write numbers in the range from N to M.\n");
    int temp = m;
    m = n;
    n = temp;
}

Console.WriteLine($"Natural numbers in the range from {m} to {n}:");
PrintNaturalNumbers(m, n);


static void PrintNaturalNumbers(int current, int end)
{
    if (current <= end)
    {
        Console.Write($"{current} ");
        PrintNaturalNumbers(current + 1, end);
    }
}