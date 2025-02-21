internal class Program
{
    private static void Main(string[] args)
    {
        Avto avto1 = new Avto(200, 6.5, 50, 87345, "LJ1234");
        Avto avto2 = new Avto(180, 7.2);
        Console.WriteLine("Avto 1:");
        avto1.izpis();
        Console.WriteLine("Avto 2:");
        avto2.izpis();
        Console.WriteLine("Dosegi avtov:");
        Console.WriteLine("Doseg avta 1: " + avto1.doseg() + " km");
        Console.WriteLine("Doseg avta 2: " + avto2.doseg() + " km");
        Console.WriteLine("Naslednji servis avta 1: " + avto1.naslednjiServis(15000) + " km");
        Console.WriteLine("Naslednji servis avta 2: " + avto2.naslednjiServis(20000) + " km");
    }
}