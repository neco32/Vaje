internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vpiši število členov zaporedja: ");
        int stclenov = int.Parse(Console.ReadLine());
        int vsota = 0;
        int n = 1;
        while (n <= stclenov)
        {
            int clen = (n+1)*(n-1);
            Console.WriteLine(n+" člen zaporedja: "+ clen);
            vsota = vsota + n;
            n++;
        }
    }
}