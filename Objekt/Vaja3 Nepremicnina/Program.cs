using Vaja3_Nepremicnina;

internal class Program
{
    private static void Main(string[] args)
    {
        Nepremicnina sola = new Nepremicnina("Cankarjeva", "10", "SCNG");
        Console.WriteLine(sola.Ulica+" "+sola.HisnaStevilka+" "+sola.Naziv);
       
    }
}