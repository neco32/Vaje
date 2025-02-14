internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi prvo število: ");
        double prvoStevilo = vpisiStevilo();

        Console.WriteLine("Vnesi drugo število: ");
        double drugoStevilo = vpisiStevilo();

        Console.WriteLine("Vnesi operacijo (+, -, *, /): ");
        string operacija = Console.ReadLine();

        double rezultat = 0;
        switch (operacija)
        {
            case "+":
                Console.WriteLine(sestej(prvoStevilo, drugoStevilo));
                break;
            case "-":
                Console.WriteLine(odstej(prvoStevilo, drugoStevilo));
                break;
            case "*":
                Console.WriteLine(zmnozi(prvoStevilo, drugoStevilo));
                break;
            case "/":
                Console.WriteLine(deli(prvoStevilo, drugoStevilo));
                break;
            default:
                Console.WriteLine("Napaka: Neznana operacija");
                Main(args);
                break;
        }
    }
    public static double sestej(double prvoStevilo, double drugoStevilo)
    {
        return prvoStevilo + drugoStevilo;
    }
    public static double odstej(double prvoStevilo, double drugoStevilo)
    {
        return prvoStevilo - drugoStevilo;
    }
    public static double zmnozi(double prvoStevilo, double drugoStevilo)
    {
        return prvoStevilo * drugoStevilo;
    }
    public static double deli(double prvoStevilo, double drugoStevilo)
    {
        return prvoStevilo / drugoStevilo;
    }
    public static double vpisiStevilo()
    {
        try
        {
            return double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Napaka: Nisi vnesel števila");
            Console.WriteLine("Vnesi število: ");
            return vpisiStevilo();
        }
    }
}