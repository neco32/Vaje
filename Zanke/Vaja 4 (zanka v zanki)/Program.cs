internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi višino vrstice:");
        int visina = int.Parse(Console.ReadLine());
        Console.WriteLine("Vnesi širino vrstice:");
        int sirina = int.Parse(Console.ReadLine());
        for (int i = 0; i < visina; i++)
        {
            for (int j = 0; j < sirina; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}