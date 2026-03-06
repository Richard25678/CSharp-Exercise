using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to count up to: ");
        int limit = int.Parse(Console.ReadLine());

        for (int i = 1; i <= limit; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Done counting!");
    }
}