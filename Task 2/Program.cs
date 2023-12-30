//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Enter the value of m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value of n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);

Console.WriteLine($"A({m}, {n}) = {result}");

static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    else
    {
        Console.WriteLine("Invalid input.");
        return -1;
    }
}
