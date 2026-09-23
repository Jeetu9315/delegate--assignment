using System;

delegate int CalculateSum(int a, int b);

class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        CalculateSum d = Sum;

        int result = d(10, 20);

        Console.WriteLine("Sum: " + result);
    }
}
