using System.Numerics;

namespace simplecalc;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("SIMPLECALC");
        Console.Write("Wprowadź pierwszą liczbę x: ");
        string xs = Console.ReadLine();
        Console.Write("Wprowadź drugą liczbę y: ");
        string ys = Console.ReadLine();
        Console.ResetColor();

        int x = int.Parse(xs);
        int y = int.Parse(ys);

        var op = Console.ReadLine();

        bool run = true;
        while (run)
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Dodaj x + y");
            Console.WriteLine("2. Odejmij x - y");
            Console.WriteLine("3. Pomnóż x * y");
            Console.WriteLine("4. Podziel x / y");
            Console.WriteLine("5. Modulo x % y");
            
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
                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbój ponownie.");
                    break;
            }  
        }
    }
    static void Sum()
    {}
    
    static void Subtraction()
    {}
    
    static void Multiplication()
    {}
    
    static void Division()
    {}
    
    static void Modulo()
    {}
    
}