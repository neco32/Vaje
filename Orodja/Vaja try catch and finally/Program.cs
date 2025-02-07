internal class Program
{
    private static void Main(string[] args)
    {
        bool delaj = true;
        while(delaj)
        {
            try
            {
                Console.WriteLine("Vnesi prvo stevilo: ");
                int stevilo = int.Parse(Console.ReadLine());
                Console.WriteLine("Vneseno drugo stevilo: ");
                int stevilo2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Rezultat deljenja je " + stevilo/stevilo2);
                delaj = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Napaka pri vnosu stevila!");
            }catch(DivideByZeroException)
            {
                Console.WriteLine("Napaka: Deljenje z 0 ni dovoljeno!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Napaka: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally blok se vedno izvede!");
            }
        }
    }
}