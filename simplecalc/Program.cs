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


        bool run = true;
        while (run)
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Dodaj x + y");
            Console.WriteLine("2. Odejmij x - y");
            Console.WriteLine("3. Pomnóż x * y");
            Console.WriteLine("4. Podziel x / y");
            Console.WriteLine("5. Modulo x % y");
            string op = Console.ReadLine();
            
            switch (op)
            {
                case "1":
                    Sum(x, y);
                    break;
                case "2":
                    Subtraction(x, y);
                    break;
                case "3":
                    Multiplication(x, y);
                    break;
                case "4":
                    Division(x, y);
                    break;
                case "5":
                    Modulo(x, y);
                    break;
                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbój ponownie.");
                    break;
            }  
        }
    }

    static void Sum(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"Wynik dodawania {x} - {y} = {sum}");
    }

    static void Subtraction(int x, int y)
    {
        int sub = x - y;
        Console.WriteLine($"Wynik odejmowania {x} - {y} = {sub}");
    }

    static void Multiplication(int x, int y)
    {
        int mult = x * y;
        Console.WriteLine($"Wynik mnożenia {x} * {y} = {mult}");
    }

    static void Division(int x, int y)
    {
        int div = x / y;
        Console.WriteLine($"Wynik dzielenia {x} / {y} = {div}");
    }

    static void Modulo(int x, int y)
    {
        int mod = x % y;
        Console.WriteLine($"Wynik modulo {x} % {y} = {mod}");
    }
    
}