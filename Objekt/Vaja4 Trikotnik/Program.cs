using Vaja4_Trikotnik;

internal class Program
{
    private static void Main(string[] args)
    {
        Trikotnik trikotnik = new Trikotnik();
        Console.WriteLine(trikotnik.a + " " + trikotnik.b + " " + trikotnik.c);
        Trikotnik trikotnik2 = new Trikotnik(3, 4, 5);
        Console.WriteLine(trikotnik2.a + " " + trikotnik2.b + " " + trikotnik2.c);
    }
}