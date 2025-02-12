internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi prvo število");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Vnesi drugo število");
        int b = int.Parse(Console.ReadLine());
        if(a<b)
        {
            Console.WriteLine("Drugo število je večje od prvega");
        }
        else if(a>b)
        {
            Console.WriteLine("Prvo število je večje od drugega");
        }
        else
        {
            Console.WriteLine("Števili sta enaki");
        }
    }
}
