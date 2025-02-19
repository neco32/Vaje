using Vaja1;

internal class Program
{
    private static void Main(string[] args)
    {
        //objekt tipa krog
        Krog k1 = new Krog();
        Console.WriteLine("Vnesi polmer kroga: ");
        k1.polmer = double.Parse(Console.ReadLine());
        Console.WriteLine("Ploščina kroga je: " + k1.ploscina());
        Krog k2 = new Krog();
        Console.WriteLine("Vnesi polmer kroga: ");
        k1.polmer = double.Parse(Console.ReadLine());
        Console.WriteLine("Ploščina kroga je: " + k2.ploscina());
    }
}