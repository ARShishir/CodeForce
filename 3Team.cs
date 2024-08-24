using System;

class Program
{
    static void Main()
    {
        //A. Team
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            int sureCount = int.Parse(inputs[0]) + int.Parse(inputs[1]) + int.Parse(inputs[2]);

            if (sureCount >= 2)
            {
                count++;
            }
        }

        Console.WriteLine(count);

    }
}
