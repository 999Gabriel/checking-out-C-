namespace EvenOrOddChecker;

public class Checker
{
    private static int number;
    private static bool isEven;
    private static bool isOdd;
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number to check if it's even or odd: ");
        while (true)
        {
            check();
        }
    }

    public static void check()
    {
        number = Convert.ToInt32(Console.ReadLine());
        
        if (number % 2 == 0)
        {
            isEven = true;
            Console.WriteLine("🥳 The number is even!");
        }
        else
        {
            isEven = false;
            Console.WriteLine("🧐 The number is odd!");
        }
    }
}