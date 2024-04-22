using System.Numerics;

namespace simplecalc;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("SIMPLECALC");
        Console.Write("Wprowadź pierwszą liczbę: ");
        string xs = Console.ReadLine();
        Console.Write("Wprowadź drugą liczbę: ");
        string ys = Console.ReadLine();
        Console.ResetColor();

        int x = int.Parse(xs);
        int y = int.Parse(ys);

        var op = Console.ReadLine();

        switch (op)
        {
            case "1":
                Sum();
                break;
            case "2":
                Subtraction();
                break;
            case "3":
                Multiplication();
                break;
            case "4":
                Division();
                break;
            case "5":
                Modulo();
                break;
        }

    }
}