using System.Numerics;

namespace simplecalc;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
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


        bool subRun = true;
        while (subRun)
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawna opcja. Spróbój ponownie.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nCzy chcesz kontynuować?");
            Console.WriteLine("1. Kontynuuj na tych samych liczbach");
            Console.WriteLine("2. Kontynuuj na nowych liczbach");
            Console.WriteLine("3. Zamknij program");
            string opp = Console.ReadLine();

            switch (opp)
            {
                case "1":
                    break;
                case "2":
                    subRun = false;
                    break;
                case "3":
                    subRun = false;
                    run = false;
                    break;
            }

        }
        }
        Console.WriteLine("Program zakończony.");
}
        
        

    static void Sum(int x, int y)
    {
        int sum = x + y;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Wynik dodawania {x} - {y} = {sum}");
        Console.ResetColor();
    }

    static void Subtraction(int x, int y)
    {
        int sub = x - y;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Wynik odejmowania {x} - {y} = {sub}");
        Console.ResetColor();
    }

    static void Multiplication(int x, int y)
    {
        int mult = x * y;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Wynik mnożenia {x} * {y} = {mult}");
        Console.ResetColor();
    }

    static void Division(int x, int y)
    {
        int div = x / y;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Wynik dzielenia {x} / {y} = {div}");
        Console.ResetColor();
    }

    static void Modulo(int x, int y)
    {
        int mod = x % y;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Wynik modulo {x} % {y} = {mod}");
        Console.ResetColor();
    }
    
}