internal class Program
{
    private static void Main(string[] args)
    {
        Avto a = new Avto("Renault", 2010, "NM-123");
        Console.WriteLine(a.ToString());
        a.SpremeniLetnik(1940);
        Console.WriteLine(a.ToString());
        a.SpremeniLetnik(2022);
        Console.WriteLine(a.ToString());
    }
}