internal class Program
{
    private static void Main(string[] args)
    {
        int[] ocene = new int[10];
        for (int i = 0; i < ocene.Length; i++)
        {
            Console.Write("Vnesi " + (i + 1) + ". oceno: ");
            ocene[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine();
        Console.WriteLine("Povprecje ocen: " + Povprecje(ocene));
        Console.WriteLine("Najmanjsa ocena: " + min(ocene));
        Console.WriteLine("Najvecja ocena: " + max(ocene));
    }
    public static double Povprecje(int[] ocene)
    {
        double vsota = 0;
        for (int i = 0; i < ocene.Length; i++)
        {
            vsota += ocene[i];
        }
        return vsota / ocene.Length;
    }
    public static int min(int[] ocene)
    {
        int min = ocene[0];
        for (int i = 1; i < ocene.Length; i++)
        {
            if (ocene[i] < min)
            {
                min = ocene[i];
            }
        }
        return min;
    }
    public static int max(int[] ocene)
    {
        int max = ocene[0];
        for (int i = 1; i < ocene.Length; i++)
        {
            if (ocene[i] > max)
            {
                max = ocene[i];
            }
        }
        return max;
    }
}