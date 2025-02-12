using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Random razred se uporablja za generiranje naključnih števil.
        Random nakljucno = new Random();
        Console.WriteLine("Naključno pozitivno število: " + nakljucno.Next());
        Console.WriteLine("Naključno število med 0 in 5: " + nakljucno.Next(6));
        Console.WriteLine("Naključno število med 10 in 20: " + nakljucno.Next(10, 21));
        Console.WriteLine("Naključno število tipa double: " + nakljucno.NextDouble());
        Console.WriteLine("Naključno število tipa double med 0.0 in 1000.0: " + nakljucno.NextDouble() * 1000);
        */
        Random nakljucno = new Random();
        int vsota = 0;
        for(int i=0; i<10; i++)
        {
            int stevilo = nakljucno.Next(100);
            Console.WriteLine("Naključno število: " + stevilo);
            vsota += stevilo;
        }
        Console.WriteLine("Vsota naključnih števil: " + vsota);
    }
}