// See https://aka.ms/new-console-template for more information

using System;

namespace simpleStuff;

public class Program
{
    private static int age = 18;
    private static int mumsAge = 47;
    public static void Main(string[] args)
    {
        if (age < 18)
        {
            Console.WriteLine("You are not Gabriel!");
        }
        else if (age > 18)
        {
            Console.Write("You are too old to be Gabriel!");
        }
        else if (age == 18)
        {
            Console.WriteLine("You are Gabriel!");
        }
    }
}