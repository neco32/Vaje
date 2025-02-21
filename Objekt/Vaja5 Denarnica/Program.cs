internal class Program
{
    private static void Main(string[] args)
    {
        Denarnica Peter = new Denarnica("Peter", 1000.0);
        Denarnica Petra = new Denarnica("Petra", 2000.0);
        Console.WriteLine("Stanje v denarnici " + Peter.ime + " je " + Peter.stanje);
        Console.WriteLine("Stanje v denarnici " + Petra.ime + " je " + Petra.stanje);
        Peter.Dvigni(235.0);
        Petra.Polozi(420.0);
        Console.WriteLine(Peter.ime + " po dvigu: " + Peter.stanje);
        Console.WriteLine(Petra.ime + " po pologu: " + Petra.stanje);
    }
}