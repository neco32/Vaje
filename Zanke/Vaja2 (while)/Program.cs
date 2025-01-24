internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi število predmetov: ");
        int stPredmetov = int.Parse(Console.ReadLine());
        int stevec = 0;
        int vsota = 0;
        int najnižja = 10;
        int najvišja = 0;
        while (stevec <= stPredmetov)
        {
            Console.WriteLine("Vnesi "+stevec+" oceno: ");
            int ocena = int.Parse(Console.ReadLine());
            if (ocena < 1 || ocena > 10)
            {
                Console.WriteLine("Ocena mora biti med 1 in 10");
                continue;
            }
            vsota += ocena;
            stevec++;
            najnižja = Math.Min(najnižja, ocena);
            najvišja = Math.Max(najvišja, ocena);
        }
        Console.WriteLine("Najnižja ocena: "+najnižja);
        Console.WriteLine("Najvišja ocena: "+najvišja);
        Console.WriteLine("Povprečna ocena: "+((double)vsota/stPredmetov));
    }
}