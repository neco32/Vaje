internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Napiši temperaturo vode v stopinjah celzija: ");
        double temp = double.Parse(Console.ReadLine());
        if (temp <= 10.0){
            Console.WriteLine("Voda je mrzla");
        } else if (temp <= 20.0){
            Console.WriteLine("Voda je hladna");
        }else if (temp <= 30.0){
            Console.WriteLine("Voda je topla");
        }else if (temp <= 50.0){
            Console.WriteLine("Voda je vroča");
        }
        
    }
}