internal class Program
{
    private static void Main(string[] args)
    {
        /*Pozdrav();
        Console.WriteLine("vnesi prvo stevilo: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("vnesi drugo stevilo: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Povprecje stevil je: " + Povprecje(a, b));*/
        Console.WriteLine("Vsota stevil je: " + Vsota());
    }
    public static void Pozdrav()
    {
        Console.WriteLine("Vnesi ime: ");
        Console.WriteLine("Pozdravljen, " + Console.ReadLine());
    }
    public static double Povprecje(double a, double b)
    {
        return (a + b) / 2.0;
    }
    public static int Vsota()
    {
        int vsota = 0;
        for(int i= 10; i < 99; i++)
        {
            if(i % 5==0)
            {
                vsota += i;
            }        
        }
        return vsota;
    }
}