internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vnesi niz:");
        string niz = Console.ReadLine();
        string samoglasniki = "aAeEiIoOuU";
        string novniz = "";
        for(int i = 0; i < niz.Length; i++)
        {
            char znak = niz[i];
            if(samoglasniki.Contains(znak))
            {
                novniz += "*";
            }else
            {
                novniz += znak;
            }
        }
        Console.WriteLine("Nov niz: "+ novniz);
    }
}