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
                var sum = x + y;
                break;
            case "2":
                var sub = x - y;
                break;
            case "3":
                var mult = x * y;
                break;
            case "4":
                var divi = x / y;
                break;
            case "5":
                var mod = x % y;
                break;
        }

    }
}