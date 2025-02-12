internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi višino v metrih");
        double visina = double.Parse(Console.ReadLine());
        Console.WriteLine("Vnesi težo v kilogramih");
        int teza = int.Parse(Console.ReadLine());
        double iti = teza / (visina * visina);
        if (iti < 18.5)
        {
            Console.WriteLine("Premajhna telesna teža");
        }
        else if (iti <= 25)
        {
            Console.WriteLine("Primerna telesna teža");
        }
        else
        {
            Console.WriteLine("Prekomerna telesna teža");
        }

    }
    
}