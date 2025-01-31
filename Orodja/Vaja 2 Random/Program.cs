internal class Program
{
    private static void Main(string[] args)
    {
        Random geslo = new Random();
        //dve nakljucni stevki
        int stevka1 = geslo.Next(10);
        int stevka2 = geslo.Next(10);
        //tri nakljucne velike crke
        char crka1 = (char)geslo.Next('A', 'Z' + 1);
        char crka2 = (char)geslo.Next('A', 'Z' + 1);
        char crka3 = (char)geslo.Next('A', 'Z' + 1);
        //ena nakljucna stevka
        int stevka3 = geslo.Next(10);
        //naključno trimestno število
        int stevilo = geslo.Next(100, 1000);
        //izpis gesla
        Console.WriteLine("Geslo: " + stevka1 + stevka2 + crka1 + crka2 + crka3 + stevka3 + stevilo);
    }
}