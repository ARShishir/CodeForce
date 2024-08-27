using System;

class Program
{
    //A. Bit++
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0; // Initial value of x

        for (int i = 0; i < n; i++)
        {
            string statement = Console.ReadLine();
            if (statement == "++X" || statement == "X++")
                x++;
            else
                x--;
        }

        Console.WriteLine(x); // Print the final value of x
    }
}

