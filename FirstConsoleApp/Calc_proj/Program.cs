using System;
namespace Calc1
{
    public class Calculator
    {
        private static int eingabe1;
        private static int eingabe2;
        
        public static void Main(string[] args)
        {
            calculate();
        }
        public static void calculate()
        {
            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            eingabe1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            eingabe2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wähle eine Operation aus: +, -, *, /");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Ergebnis: " + (eingabe1 + eingabe2));
                    break;
                case "-":
                    Console.WriteLine("Ergebnis: " + (eingabe1 - eingabe2));
                    break;
                case "*":
                    Console.WriteLine("Ergebnis: " + (eingabe1 * eingabe2));
                    break;
                case "/":
                    Console.WriteLine("Ergebnis: " + (eingabe1 / eingabe2));
                    break;
            }
            Console.WriteLine("Noch eine Aufgabe? (y/n):");
            if (Console.ReadLine() == "y")
            {
                calculate();
            }
            else
            {
                Console.WriteLine("Alles klar dann halt nicht du Nigga!");
            }
        }
    }
}