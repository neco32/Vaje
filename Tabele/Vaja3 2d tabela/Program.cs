internal class Program
{
    /// <summary>
    /// Ustvari 10x10 tabelo naključnih celih števil med 0 in 100, jo izpiše na konzolo,
    /// izračuna največje število in vsoto vseh števil v tabeli ter izpiše diagonale.
    /// </summary>
    /// <param name="args">Argumenti ukazne vrstice.</param>
    /// <remarks>
    /// Tabela je izpisana tako, da je vsako celo število formatirano, da zavzame 5 znakov za boljšo poravnavo.
    /// </remarks>
    /// <example>
    /// Izhod bo 10x10 mreža naključnih celih števil, vsako formatirano na širino 5 znakov:
    /// <code>
    ///    23    45    67    89    12    34    56    78    90    12
    ///    34    56    78    90    12    34    56    78    90    12
    ///    ...
    /// </code>
    /// </example>
    private static void Main(string[] args)
    {
        // Ustvari 10x10 tabelo
        int[,] tabela = new int[10, 10];
        int max = 0;
        int vsota = 0;
        Random rnd = new Random();

        // Polni tabelo z naključnimi števili in izračuna največje število ter vsoto
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tabela[i, j] = rnd.Next(101);
                if (tabela[i, j] > max)
                {
                    max = tabela[i, j];
                }
                vsota += tabela[i, j];
                Console.Write("{0, 5}", tabela[i, j]);
            }
            Console.WriteLine();
        }

        // Izpiše največje število in vsoto vseh števil v tabeli
        Console.WriteLine("Največje število v tabeli je: " + max);
        Console.WriteLine("Vsota vseh števil v tabeli je: " + vsota);

        // Izpiše diagonale tabele
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == j || i + j == 9)
                {
                    Console.Write(tabela[i, j] + "\t");
                }
                else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }
}