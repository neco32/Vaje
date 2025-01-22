internal class Program
{
    private static void Main(string[] args)
    {
        /**/
        Console.WriteLine("Vnesi leto");
        int leto = int.Parse(Console.ReadLine());
        if(leto%4==0 && (leto%100!=0 || leto%400==0))
        {
            Console.WriteLine("Leto je prestopno - praznovala bo 29. februarja");
        }
        else
        {
            Console.WriteLine("Leto ni prestopno - praznovala bo 1. marca");
        }
    }
}