using System;

class Program
{
    static void Main()
    {
        //A. Watermelon Solving problem

        int w = int.Parse(Console.ReadLine());
        if (w % 2 == 0 && w > 2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
