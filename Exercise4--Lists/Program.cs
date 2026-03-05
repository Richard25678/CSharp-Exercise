using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");
        fruits.Add("Orange");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}