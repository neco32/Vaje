internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi velikost tabele: ");
        int velikost = int.Parse(Console.ReadLine());
        int[] tabela = new int[velikost];
        for (int i = 0; i < tabela.Length; i++)
        {
            Console.WriteLine("Vnesi " + (i + 1) + ". element tabele: ");
            tabela[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < tabela.Length; i++)
        {
            Console.Write(tabela[i]+ " ");
        }
        for(int i = tabela.Length - 1; i >= 0; i--)
        {
            int min=tabela[i];
            int minIndex = i;
            for(int j = i; j >= 0; j--)
            {
                if(tabela[j] < min)
                {
                    min = tabela[j];
                    minIndex = j;
                }
            }
            int temp = tabela[i];
            tabela[i] = tabela[minIndex];
            tabela[minIndex] = temp;
        }
    }
}