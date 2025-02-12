internal class Program
{
    private static void Main(string[] args)
    {
        double[] meseci = new double[12];
        double vsota = 0;
        for (int i = 0; i < meseci.Length; i++)
        {
            Console.Write("Povprečna  temperatura v mesecu " + (i + 1) + ": ");
            meseci[i] = double.Parse(Console.ReadLine());
            vsota += meseci[i];
        }
        double povprecje = vsota / 12;
        Console.WriteLine("Povprečna temperatura v letu je: " + povprecje);
        for (int i = 0; i < meseci.Length; i++)
        {
            if (meseci[i] > povprecje)
            {
                Console.WriteLine("V mesecu " + (i + 1) + " je bila temperatura nad povprečjem.");
            }
        }
    }
}