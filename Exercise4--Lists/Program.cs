using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Enter fruit #{i}: ");
            string fruit = Console.ReadLine();
            fruits.Add(fruit);
        }

        Console.WriteLine("\nYour fruits are:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}