internal class Program
{
    /// <summary>
    /// Ustvari 10x10 tabelo naključnih celih števil med 0 in 100 in jo izpiše na konzolo.
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
        int[,] tabela = new int[10, 10];
        int max = 0;
        int vsota = 0;
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tabela[i, j] = rnd.Next(101);
                if(tabela[i, j] > max)
                {
                    max = tabela[i, j];
                }
                vsota += tabela[i, j];
                //Console.Write(tabela[i, j] + "\t");
                Console.Write("{0, 5}", tabela[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Največje število v tabeli je: " + max);
        Console.WriteLine("Vsota vseh števil v tabeli je: " + vsota);
        for(int i=0; i<10; i++)
        {
            for(int j=0; j<10; j++)
            {
                if(i==j)
                {
                    Console.Write(tabela[i, j]+"\t");
                }else if(i+j==9)
                {
                    Console.Write(tabela[i, j]+"\t");
                }else
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }
}