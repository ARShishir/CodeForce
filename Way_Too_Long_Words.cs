using System;

class Program
{
    static void Main()
    {
        //A. Way Too Long Words

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            if (word.Length > 10)
            {
                Console.WriteLine($"{word[0]}{word.Length - 2}{word[word.Length - 1]}");
            }
            else
            {
                Console.WriteLine(word);
            }
        }
    }
}
