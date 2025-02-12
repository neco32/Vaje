internal class Program
{
    private static void Main(string[] args)
    {
        char[,] tabela = new char[5, 5];
        Random rnd = new Random();
        char min = 'z';
        for (int i = 0; i < tabela.GetLength(0); i++)
        {
            for (int j = 0; j < tabela.GetLength(1); j++)
            {
                tabela[i, j] = (char)(rnd.Next(25) + 97);
                Console.Write(tabela[i, j] + "\t");
                if (tabela[i, j] < min)
                {
                    min = tabela[i, j];
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Najmanjši znak v tabeli je: " + min);
    }
}