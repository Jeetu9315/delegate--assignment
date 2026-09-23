using System;

delegate void MyDelegate();

class Program
{
    static void Method1()
    {
        Console.WriteLine("Method 1");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2");
    }

    static void Main()
    {
        MyDelegate unicast = Method1;

        Console.WriteLine("Unicast Delegate:");
        unicast();

        MyDelegate multicast = Method1;
        multicast += Method2;

        Console.WriteLine("Multicast Delegate:");
        multicast();
    }
}
