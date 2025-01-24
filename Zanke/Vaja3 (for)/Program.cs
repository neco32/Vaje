using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int min = int.MaxValue;
        for(int i = 1; i <= 10; i++)
        {
            Console.Write("Vnesi število: ");
            int stevilo = int.Parse(Console.ReadLine());
            if(stevilo < min)
            {
                min = stevilo;
            }
        }
        Console.WriteLine("Najmanjše število je: " + min);
    }
}