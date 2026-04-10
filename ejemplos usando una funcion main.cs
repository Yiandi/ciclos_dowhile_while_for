using System;

class Program
{
    static void Main()
    {
        // while
        int a = 1;
        while (a <= 3)
        {
            Console.WriteLine("While: " + a);
            a++;
        }

        // do while
        int b = 1;
        do
        {
            Console.WriteLine("Do While: " + b);
            b++;
        }
        while (b <= 3);

        // for
        for (int c = 1; c <= 3; c++)
        {
            Console.WriteLine("For: " + c);
        }
    }
}
