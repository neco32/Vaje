internal class Program
{
    private static void Main(string[] args)
    {
        int[,] tabela = new int[10, 10];
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tabela[i, j] = rnd.Next(101);
                //Console.Write(tabela[i, j] + "\t");
                Console.Write("{0, 5}", tabela[i, j]);
            }
            Console.WriteLine();
        }
    }
}